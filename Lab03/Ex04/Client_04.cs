using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Net;
using System.Drawing;
using System.Windows.Forms;
using TcpServerClient;

namespace Lab03.Ex04
{
	public partial class Client_04 : Form
	{
		private STcpClient _client = null;
		private List<ArraySegment<byte>> _temp;
		private string _username;
		private delegate void DisplayMessageDelegate(string message, Image image);
		private DisplayMessageDelegate _displayMessageDelegate = null;
		private ConcurrentDictionary<string, string> _usernames = new ConcurrentDictionary<string, string>();
		private ConcurrentDictionary<string, DirectMessage> _directMessageFormList = new ConcurrentDictionary<string, DirectMessage>();

		public Client_04()
		{
			InitializeComponent();
		}

		private void Client_Load(object sender, EventArgs e)
		{
			clientDisconnectButton.Enabled = false;
			clientSendButton.Enabled = false;
			_displayMessageDelegate = new DisplayMessageDelegate(DisplayMessage);
			listViewUsers.View = View.Details;
			ColumnHeader usernameColumn = new ColumnHeader();
			usernameColumn.Text = "Usernames";
			usernameColumn.Width = 347;
			listViewUsers.Columns.Add(usernameColumn);
		}

		private void clientConnectButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(nameTxt.Text))
			{
				MessageBox.Show("Vui lòng nhập Tên tài khoản và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(serverPortTxt.Text))
			{
				MessageBox.Show("Vui lòng nhập Port và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(serverIPTxt.Text))
			{
				MessageBox.Show("Vui lòng nhập IP và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!IPAddress.TryParse(serverIPTxt.Text, out var serverIP))
			{
				MessageBox.Show("Địa chỉ IP không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Int32.TryParse(serverPortTxt.Text, out var serverPort))
			{
				MessageBox.Show("Số port không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (serverPort < 0 || serverPort > 65535)
			{
				MessageBox.Show("Số port phải lớn hơn 0 và nhỏ hơn hoặc bằng 65535", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_username = nameTxt.Text;
			_client = new STcpClient($"{serverIP}:{serverPort}");
			try
			{
				_client.Events.Connected += Connected;
				_client.Events.DataReceived += DataReceived;
				_client.Events.ServerDisconnected += ServerDisconnected;
				clientConnectButton.Enabled = false;
				_client.Connect();
			}
			catch (TimeoutException)
			{
				clientConnectButton.Enabled = true;
				MessageBox.Show("Connection Error: TimeOut", "TcpClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void clientDisconnectButton_Click(object sender, EventArgs e)
		{
			ClientDisconnect();
		}

		private void Client_04_FormClosing(object sender, FormClosingEventArgs e)
		{
			ClientDisconnect();
		}

		private void ClientDisconnect()
		{
			Task.Run(() =>
			{
				_client.Dispose();
				_client = null;
				_usernames.Clear();
			});
			foreach (var form in _directMessageFormList.Values)
			{
				form.Dispose();
			}
			clientConnectButton.Enabled = true;
			clientDisconnectButton.Enabled = false;
		}

		private void ServerDisconnected(object sender, ConnectionEventArgs e)
		{
			this.Invoke(_displayMessageDelegate, new Object[] { $"--- Mất kết nối đến server ---", null });
			clientConnectButton.Invoke(new Action(() => clientConnectButton.Enabled = true));
			clientDisconnectButton.Invoke(new Action(() => clientDisconnectButton.Enabled = false));
			listViewUsers.Invoke(new Action(() => listViewUsers.Items.Clear()));
		}

		[STAThread]
		private void DataReceived(object sender, DataReceivedEventArgs e)
		{
			if (_temp == null)
				_temp = new List<ArraySegment<byte>>();
			if (e.Data.Count == 65536)
			{
				_temp.Add(e.Data);
				return;
			}
			_temp.Add(e.Data);

			int totalLength = _temp.Sum(segment => segment.Count);
			byte[] resultArray = new byte[totalLength];
			int offset = 0;
			foreach (var segment in _temp)
			{
				Array.Copy(segment.Array, segment.Offset, resultArray, offset, segment.Count);
				offset += segment.Count;
			}
			var arraySegment = new ArraySegment<byte>(resultArray);

			object obj = Common.ArraySegmentToObject(arraySegment);
			ChatPacket packet = obj as ChatPacket;
			_temp.Clear();
			_temp = null;

			if (packet != null)
			{
				switch (packet.Command)
				{
					case Cmd.Login:
						_usernames = JsonConvert.DeserializeObject<ConcurrentDictionary<string, string>>(packet.Content);
						UpdateClientList();
						this.Invoke(_displayMessageDelegate, new Object[] { $"--- {packet.Username} vừa tham gia vào phòng chat ---", null });
						break;
					case Cmd.Message:
						var message = JsonConvert.DeserializeObject<Message>(packet.Content);
						if (!message.IsImage)
						{
							this.Invoke(_displayMessageDelegate, new Object[] { $"{packet.Username} => {message.Content}", null });
						}
						else
						{
							
							var image = Common.DeserializeImage(message.Content);
							this.Invoke(_displayMessageDelegate, new Object[] { $"{packet.Username} => ", image });
						}
						break;
					case Cmd.Logout:
						_usernames = JsonConvert.DeserializeObject<ConcurrentDictionary<string, string>>(packet.Content);
						UpdateClientList();
						this.Invoke(_displayMessageDelegate, new Object[] { $"--- {packet.Username} thoát khỏi phòng chat ---", null });
						break;
					case Cmd.DirectMessage:
						var DMPacket = JsonConvert.DeserializeObject<DirectMessagePacket>(packet.Content);
						var form = OpenDirectMessage(packet.Username);
						form.ReceivedMessage(DMPacket.Message);
						break;
				}
			}
		}

		private void Connected(object sender, ConnectionEventArgs e)
		{
			this.Invoke(new MethodInvoker(() => clientDisconnectButton.Enabled = true));
			SendJoin();
			this.Invoke(_displayMessageDelegate, new Object[] { $"Đã kết nối đến server", null });
		}

		private void SendJoin()
		{
			var packet = new ChatPacket();
			packet.Username = _username;
			packet.Command = Cmd.Login;
			var Data = Common.ObjectToArraySegment(packet);
			_client.Send(Data.ToArray());
		}

		private void DisplayMessage(string message, Image image)
		{
			clientChatView.AppendText(message);
			if (image != null)
			{
				Thread t = new Thread((ThreadStart)(() => {
					Clipboard.SetImage(image);
				}));
				t.SetApartmentState(ApartmentState.STA);
				t.Start();
				t.Join();
				clientChatView.SelectionStart = clientChatView.TextLength;
				clientChatView.SelectionLength = 0;
				Clipboard.SetImage(image);
				clientChatView.Paste();
				Clipboard.Clear();
			}
			clientChatView.SelectionStart = clientChatView.TextLength;
			clientChatView.SelectionLength = 0;
			clientChatView.AppendText(Environment.NewLine);
		}

		private void msgTxt_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(msgTxt.Text))
			{
				clientSendButton.Enabled = false;
			}
			else if (_client.IsConnected)
			{
				clientSendButton.Enabled = true;
			}
		}

		private void clientSendButton_Click(object sender, EventArgs e)
		{
			var Chat = new ChatPacket();
			Chat.Username = _username;
			Chat.Command = Cmd.Message;
			var message = new Message(msgTxt.Text, false);
			Chat.Content = JsonConvert.SerializeObject(message);
			var Data = Common.ObjectToArraySegment(Chat);
			try
			{
				_client.Send(Data.ToArray());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Send Error: " + ex.Message, "TcpClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			msgTxt.Text = string.Empty;
			clientSendButton.Enabled = false;
		}

		private void buttonSendImage_Click(object sender, EventArgs e)
		{
			var Chat = new ChatPacket();
			Chat.Username = _username;
			Chat.Command = Cmd.Message;
			var imagePath = GetFilePath();
			if (imagePath == string.Empty)
				return;
			Image image = Image.FromFile(imagePath);
			var imageJson = Common.SerializeImage(image);
			var message = new Message(imageJson, true);
			Chat.Content = JsonConvert.SerializeObject(message);
			var Data = Common.ObjectToArraySegment(Chat);
			try
			{
				_client.Send(Data.ToArray());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Send Error: " + ex.Message, "TcpClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetFilePath()
		{
			try
			{
				var openFileDialog = new OpenFileDialog
				{
					Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
				};
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					return openFileDialog.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return string.Empty;
		}

		private void UpdateClientList()
		{
			List<ListViewItem> items = _usernames.Values.Select(item => new ListViewItem(item)).ToList();
			listViewUsers.Invoke(new Action(() => listViewUsers.Items.Clear()));
			listViewUsers.Invoke(new Action(() => listViewUsers.Items.AddRange(items.ToArray())));
		}

		private void listViewUsers_DoubleClick(object sender, EventArgs e)
		{
			if (listViewUsers.SelectedItems.Count == 1)
			{
				var userName = listViewUsers.SelectedItems[0].SubItems[0].Text;
				if (userName == _username) { return; }
				OpenDirectMessage(userName);
			}
		}

		private DirectMessage OpenDirectMessage(string toUserName)
		{
			DirectMessage form = null;

			if (_directMessageFormList.TryGetValue(toUserName, out form))
			{
				if (!form.IsHandleCreated)
				{
					if (form.InvokeRequired)
					{
						form.Invoke(new MethodInvoker(() => form = new DirectMessage(_username, toUserName, _client)));
					}
					else
					{
						form = new DirectMessage(_username, toUserName, _client);
					}
				}
				else if (!form.Visible)
				{
					if (form.InvokeRequired)
					{
						form.Invoke(new MethodInvoker(() => form.Show()));
					}
					else
					{
						form.Show();
					}
				}
			}
			else
			{
				if (InvokeRequired)
				{
					Invoke(new MethodInvoker(() =>
					{
						form = new DirectMessage(_username, toUserName, _client);
						_directMessageFormList.TryAdd(toUserName, form);
						form.Show();
					}));
				}
				else
				{
					form = new DirectMessage(_username, toUserName, _client);
					_directMessageFormList.TryAdd(toUserName, form);
					form.Show();
				}
			}

			return form;
		}
	}
}

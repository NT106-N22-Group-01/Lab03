﻿using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Net;
using TcpServerClient;

namespace Lab03.Ex04
{
	public partial class Client_04 : Form
	{
		private STcpClient _client = null;
		private string _username;
		private delegate void DisplayMessageDelegate(string message);
		private DisplayMessageDelegate _displayMessageDelegate = null;
		private ConcurrentDictionary<string, string> _usernames = new ConcurrentDictionary<string, string>();
		Dictionary<string, DirectMessage> _directMessageFormList = new Dictionary<string, DirectMessage>();

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
			Task.Run(() =>
			{
				_client.Disconnect();
				_client.Dispose();
				_client = null;
			});
			clientConnectButton.Enabled = true;
			clientDisconnectButton.Enabled = false;
		}

		private void ServerDisconnected(object sender, ConnectionEventArgs e)
		{
			this.Invoke(_displayMessageDelegate, new Object[] { $"--- Mất kết nối đến server ---" });
			clientConnectButton.Invoke(new Action(() => clientConnectButton.Enabled = true));
			clientDisconnectButton.Invoke(new Action(() => clientDisconnectButton.Enabled = false));
			listViewUsers.Invoke(new Action(() => listViewUsers.Items.Clear()));
		}

		private void DataReceived(object sender, DataReceivedEventArgs e)
		{
			object obj = Common.ArraySegmentToObject(e.Data);
			ChatPacket packet = obj as ChatPacket;

			if (packet != null)
			{
				switch (packet.Command)
				{
					case Cmd.Login:
						_usernames = JsonConvert.DeserializeObject<ConcurrentDictionary<string, string>>(packet.Content);
						UpdateClientList();
						this.Invoke(_displayMessageDelegate, new Object[] { $"--- {packet.Username} vừa tham gia vào phòng chat ---" });
						break;
					case Cmd.Message:
						this.Invoke(_displayMessageDelegate, new Object[] { $"{packet.Username} => {packet.Content}" });
						break;
					case Cmd.Logout:
						_usernames = JsonConvert.DeserializeObject<ConcurrentDictionary<string, string>>(packet.Content);
						UpdateClientList();
						this.Invoke(_displayMessageDelegate, new Object[] { $"--- {packet.Username} thoát khỏi phòng chat ---" });
						break;
				}
			}
		}

		private void Connected(object sender, ConnectionEventArgs e)
		{
			this.Invoke(new MethodInvoker(() => clientDisconnectButton.Enabled = true));
			SendJoin();
			this.Invoke(_displayMessageDelegate, new Object[] { $"Đã kết nối đến server" });
		}

		private void SendJoin()
		{
			var packet = new ChatPacket();
			packet.Username = _username;
			packet.Command = Cmd.Login;
			var Data = Common.ObjectToArraySegment(packet);
			_client.Send(Data.ToArray());
		}

		private void DisplayMessage(string message)
		{
			clientChatView.Text += message + Environment.NewLine;
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
			Chat.Content = msgTxt.Text;
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
				var userName = listViewUsers.SelectedItems[0].SubItems[1].Text;
				OpenDirectMessage(userName);
			}
		}

		private DirectMessage OpenDirectMessage(string userName)
		{
			DirectMessage form;
			if  (_directMessageFormList.ContainsKey(userName))
			{
				form = _directMessageFormList[userName];
				if (!form.Created) 
				{
					form = new DirectMessage(userName);
				}
				form.Show();
			}
			else
			{
				form = new DirectMessage(userName);
				_directMessageFormList[userName] = form;
				form.Show();
			}
			return form;
		}
	}
}

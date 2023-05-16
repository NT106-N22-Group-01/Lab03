using Newtonsoft.Json;
using TcpServerClient;

namespace Lab03.Ex04
{
	public partial class DirectMessage : Form
	{
		private STcpClient _client;
		private string _userName;
		private string _toUserName;
		private delegate void DisplayMessageDelegate(string message);
		private DisplayMessageDelegate _displayMessageDelegate = null;
		public DirectMessage(string userName, string toUserName, STcpClient client)
		{
			InitializeComponent();
			Text = toUserName;
			_userName = userName;
			_toUserName = toUserName;
			_client = client;
			clientSendButton.Enabled = false;
			_displayMessageDelegate = new DisplayMessageDelegate(DisplayMessage);
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
			var packet = new ChatPacket();
			packet.Username = _userName;
			packet.Command = Cmd.DirectMessage;
			Message message = new Message(msgTxt.Text, false);
			var directMessage = new DirectMessagePacket(_toUserName, message);
			packet.Content = JsonConvert.SerializeObject(directMessage);
			var Data = Common.ObjectToArraySegment(packet);
			_client.Send(Data.ToArray());
			this.Invoke(_displayMessageDelegate, new Object[] { $"{_userName} => {directMessage.Message}" });
			msgTxt.Text = string.Empty;
		}

		public void ReceivedMessage(Message message)
		{
			this.Invoke(_displayMessageDelegate, new Object[] { $"{_toUserName} => {message.Content}" });
		}

		private void DisplayMessage(string message)
		{
			clientChatView.Text += message + Environment.NewLine;
		}

		private void DirectMessage_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				this.Hide();
			}
		}
	}
}

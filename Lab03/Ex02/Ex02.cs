using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Lab03.Ex02
{
	public partial class Ex02 : Form
	{
		public Ex02()
		{
			InitializeComponent();
		}

		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btbLis_Click(object sender, EventArgs e)
		{

			CheckForIllegalCrossThreadCalls = false;
			Thread severthread = new Thread(new ThreadStart(StartThread));
			severthread.Start();
		}
		private void StartThread()
		{
			listView.Items.Add(new ListViewItem("Waiting for connetion"));
			int bytesRecv = 0;
			byte[] recv = new byte[1];
			Socket clientSocket;

			Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint ipepSV = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
			listenerSocket.Bind(ipepSV);
			listenerSocket.Listen(-1);
			clientSocket = listenerSocket.Accept();

			listView.Items.Add(new ListViewItem("New client conneted"));

			while (clientSocket.Connected)
			{
				string text = "";
				do
				{
					bytesRecv = clientSocket.Receive(recv);
					text += Encoding.ASCII.GetString(recv);
				}
				while (text[text.Length - 1] != '\n');
				if (string.IsNullOrEmpty(text.Trim()))
				{
					Application.Exit();
				}
				listView.Items.Add(new ListViewItem("You said: " + text));
			}

			listenerSocket.Close();
		}

		private void Ex02_FormClosed(object sender, FormClosedEventArgs e)
		{
			var main = new MainForm();
			main.Show();
		}
	}
}

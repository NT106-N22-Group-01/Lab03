using System.Net;
using System.Net.Sockets;

namespace Lab03.Ex03
{
	public partial class ServerEx03 : Form
	{
		private TcpListener? tcpListener;
		private Thread? serverThread;
		private bool isRunning = false;

		public ServerEx03()
		{
			InitializeComponent();
		}

		public void StartThread()
		{
			try
			{
				tcpListener = new TcpListener(IPAddress.Loopback, 8000);
				tcpListener.Start();
				isRunning = true;

				AddMessage("Server started");
				var client = tcpListener.AcceptTcpClient();

				AddMessage($"Connection accepted from {client.Client.RemoteEndPoint}");

				using var stream = client.GetStream();
				using var reader = new StreamReader(stream);

				while (isRunning)
				{
					var message = reader.ReadLine();
					AddMessage($"Client: {message}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				tcpListener?.Stop();
				btnListen.Invoke(new Action(() => btnListen.Enabled = false));
			}
		}

		private void btnListen_Click(object sender, EventArgs e)
		{
			if (!isRunning)
			{
				serverThread = new Thread(() => StartThread());
				serverThread.Start();
				btnListen.Enabled = false;
			}
		}

		private void AddMessage(string message)
		{
			if (lvMessage.InvokeRequired)
			{
				lvMessage.Invoke(new Action(() => lvMessage.Items.Add(message)));
			}
			else
			{
				lvMessage.Items.Add(message);
			}
		}

		private void ServerEx03_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (isRunning)
			{
				isRunning = false;
				tcpListener?.Stop();
				serverThread.Join();
			}
		}
	}
}

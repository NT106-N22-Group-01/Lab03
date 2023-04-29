using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab03.Ex03
{
    public partial class ClientEx03 : Form
    {
		private TcpClient tcpClient = new TcpClient();
		private Stream stream;
		private StreamWriter writer;
		private bool isConnected = false;

		public ClientEx03()
        {
            InitializeComponent();
        }

        private void Connect()
        {
			try
			{
				tcpClient.Connect(IPAddress.Loopback, 8000);
				stream = tcpClient.GetStream();
				writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };
				isConnected = true;
				UpdateControls();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void Send()
        {
			if (isConnected)
			{
				try
				{
					var message = tbMessage.Text;
					writer.WriteLine(message);
					tbMessage.Text = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

        private void Disconnect()
        {
			if (!isConnected)
				return;
			try
			{
				tcpClient.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			isConnected = false;
			UpdateControls();
		}

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void ClientEx03_Load(object sender, EventArgs e)
        {
			UpdateControls();
		}

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
		}

		private void UpdateControls()
		{
			btnConnect.Enabled = !isConnected;
			btnSend.Enabled = isConnected && !string.IsNullOrWhiteSpace(tbMessage.Text);
			btnDisconnect.Enabled = isConnected;
		}
	}
}

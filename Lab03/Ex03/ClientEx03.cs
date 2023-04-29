using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Ex03
{
    public partial class ClientEx03 : Form
    {
        TcpClient tcpClient = new TcpClient();
        public ClientEx03()
        {
            InitializeComponent();
        }

        private void connect()
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8000);
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void send()
        {
            Stream stream = tcpClient.GetStream();
            var writer = new StreamWriter(stream);
            writer.Write(tbMessage.Text.Trim());
            writer.Flush();
            writer.Close();
            stream.Close();
        }

        private void disconnect()
        {
            tcpClient.Close();
            btnConnect.Enabled = true;
            btnSend.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.connect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.send();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.disconnect();
        }

        private void ClientEx03_Load(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnSend.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMessage.Text.Trim()))
                btnSend.Enabled = false;
            
            if (string.IsNullOrEmpty (tbMessage.Text.Trim()) == false)
                btnSend.Enabled = true;
                
        }
    }
}

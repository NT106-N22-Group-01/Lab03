using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Ex03
{
    public partial class ServerEx03 : Form
    {
        public ServerEx03()
        {
            InitializeComponent();
        }

        public void startThread()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8000);
            tcpListener.Start();
            Socket socket = tcpListener.AcceptSocket();

            lvMessage.Items.Add("Server started");
            lvMessage.Items.Add("Connection accepted from " + socket.RemoteEndPoint);
            lvMessage.Items.Add("From client: This is Lab03");

            var stream = new NetworkStream(socket);
            var reader = new StreamReader(stream);

            while (socket.Connected)
            {
                string text = reader.ReadToEnd();
                lvMessage.Items.Add($"{text}");
            }

            stream.Close();
            socket.Close();
            tcpListener.Stop();
            btnListen.Enabled = true;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverthd = new Thread(startThread);
            serverthd.Start();
            btnListen.Enabled = false;
        }
    }
}

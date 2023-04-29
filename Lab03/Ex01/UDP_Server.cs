using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class task01_udpserver : Form
    {
        UdpClient _udpServer;

        public task01_udpserver()
        {
            InitializeComponent();
            portTxt.ReadOnly = true;
            portTxt.Text = "8080";
        }

        private async void listenButton_Click(object sender, EventArgs e)
        {
            try
            { 
                _udpServer = new UdpClient(Int32.Parse(portTxt.Text));
                viewOutput.Text += $"Server started on port {Int32.Parse(portTxt.Text)}\r\n";
                while (true)
                {
                    var receivedResults = await _udpServer.ReceiveAsync();
                    var receivedData = Encoding.UTF8.GetString(receivedResults.Buffer);
                    viewOutput.Text += $"Received: {receivedData}\r\n";
                    await _udpServer.SendAsync(Encoding.UTF8.GetBytes(receivedData), receivedData.Length, receivedResults.RemoteEndPoint);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

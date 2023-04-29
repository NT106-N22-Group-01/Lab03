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

namespace Lab03
{
    public partial class task01_udpclient : Form
    {
        UdpClient _udpClient;

        public task01_udpclient()
        {
            InitializeComponent();
            portTxt.Text = "8080";
            portTxt.ReadOnly = true;
            IPTxt.ReadOnly = true;
            IPTxt.Text = "127.0.0.1";
            
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                _udpClient = new UdpClient();
                var serverEP = new IPEndPoint(IPAddress.Parse(IPTxt.Text), Int32.Parse(portTxt.Text));
                var msgBytes = Encoding.UTF8.GetBytes(msgTxt.Text);

                await _udpClient.SendAsync(msgBytes, msgBytes.Length, serverEP);

                var receivedResults = await _udpClient.ReceiveAsync();
                var receivedData = Encoding.UTF8.GetString(receivedResults.Buffer);


                viewOutput.Text += $"From Server: {receivedData}\r\n";
                _udpClient.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Ex03
{
    public partial class Ex03 : Form
    {
        public Ex03()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            var server3 = new ServerEx03();
            server3.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            var client3 = new ClientEx03();
            client3.Show();
        }

        private void Ex03_FormClosed(object sender, FormClosedEventArgs e)
        {
            var main = new MainForm();
            main.Show();
        }
    }
}

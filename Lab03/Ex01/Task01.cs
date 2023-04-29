namespace Lab03
{
    public partial class task01 : Form
    {
        public task01()
        {
            InitializeComponent();
        }

        private void server_Click(object sender, EventArgs e)
        {
            task01_udpserver Server = new task01_udpserver();
            Server.Show();
        }

        private void client_Click(object sender, EventArgs e)
        {
            task01_udpclient Client = new task01_udpclient();
            Client.Show();
        }
    }
}
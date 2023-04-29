namespace Lab03.Ex04
{
	public partial class Landing_04 : Form
	{
		public Landing_04()
		{
			InitializeComponent();
		}

		private void buttonServer_Click(object sender, EventArgs e)
		{
			var Server = new Server_04();
			Server.Show();
		}

		private void buttonClient_Click(object sender, EventArgs e)
		{
			var Client = new Client_04();
			Client.Show();
		}

		private void Landing_04_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}
	}
}

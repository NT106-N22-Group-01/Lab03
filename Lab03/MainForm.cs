namespace Lab03
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.FormClosed += (sender, e) => Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonEx01_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex01 = new Ex01();
			Ex01.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
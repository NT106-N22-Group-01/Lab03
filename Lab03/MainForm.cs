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
			var Ex01 = new task01();
			Ex01.Show();
		}

		private void buttonEx2_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex02 = new Lab03.Ex02.Ex02();
			Ex02.Show();
		}

		private void buttonEx3_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex03 = new Lab03.Ex03.Ex03();
			Ex03.Show();
		}

		private void buttonEx4_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex04 = new Lab03.Ex04.Landing_04();
			Ex04.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
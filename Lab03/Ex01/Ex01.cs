namespace Lab03
{
	public partial class Ex01 : Form
	{
		public Ex01()
		{
			InitializeComponent();
		}

		private void Ex01_FormClosed(object sender, FormClosedEventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}
	}
}

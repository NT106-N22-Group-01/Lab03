namespace Lab03.Ex03
{
	partial class Ex03
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnServer = new Button();
			btnClient = new Button();
			SuspendLayout();
			// 
			// btnServer
			// 
			btnServer.Location = new Point(176, 72);
			btnServer.Margin = new Padding(4, 5, 4, 5);
			btnServer.Name = "btnServer";
			btnServer.Size = new Size(181, 63);
			btnServer.TabIndex = 0;
			btnServer.Text = "Server";
			btnServer.UseVisualStyleBackColor = true;
			btnServer.Click += btnServer_Click;
			// 
			// btnClient
			// 
			btnClient.Location = new Point(176, 205);
			btnClient.Margin = new Padding(4, 5, 4, 5);
			btnClient.Name = "btnClient";
			btnClient.Size = new Size(181, 63);
			btnClient.TabIndex = 1;
			btnClient.Text = "Client";
			btnClient.UseVisualStyleBackColor = true;
			btnClient.Click += btnClient_Click;
			// 
			// Ex03
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(539, 348);
			Controls.Add(btnClient);
			Controls.Add(btnServer);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Ex03";
			Text = "Exercise 03";
			FormClosed += Ex03_FormClosed;
			ResumeLayout(false);
		}

		#endregion

		private Button btnServer;
		private Button btnClient;
	}
}
namespace Lab03.Ex04
{
	partial class Landing_04
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
			buttonServer = new Button();
			buttonClient = new Button();
			SuspendLayout();
			// 
			// buttonServer
			// 
			buttonServer.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonServer.Location = new Point(102, 68);
			buttonServer.Name = "buttonServer";
			buttonServer.Size = new Size(175, 41);
			buttonServer.TabIndex = 0;
			buttonServer.Text = "Server";
			buttonServer.UseVisualStyleBackColor = true;
			buttonServer.Click += buttonServer_Click;
			// 
			// buttonClient
			// 
			buttonClient.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonClient.Location = new Point(437, 68);
			buttonClient.Name = "buttonClient";
			buttonClient.Size = new Size(175, 41);
			buttonClient.TabIndex = 1;
			buttonClient.Text = "Client";
			buttonClient.UseVisualStyleBackColor = true;
			buttonClient.Click += buttonClient_Click;
			// 
			// Landing_04
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(698, 186);
			Controls.Add(buttonClient);
			Controls.Add(buttonServer);
			Name = "Landing_04";
			Text = "Landing_04";
			FormClosed += Landing_04_FormClosed;
			ResumeLayout(false);
		}

		#endregion

		private Button buttonServer;
		private Button buttonClient;
	}
}
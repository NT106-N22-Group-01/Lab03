namespace Lab03
{
	partial class task01
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			server = new Button();
			client = new Button();
			SuspendLayout();
			// 
			// server
			// 
			server.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			server.Location = new Point(43, 83);
			server.Margin = new Padding(4, 5, 4, 5);
			server.Name = "server";
			server.Size = new Size(143, 83);
			server.TabIndex = 0;
			server.Text = "Server";
			server.UseVisualStyleBackColor = true;
			server.Click += server_Click;
			// 
			// client
			// 
			client.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			client.Location = new Point(221, 83);
			client.Margin = new Padding(4, 5, 4, 5);
			client.Name = "client";
			client.Size = new Size(143, 83);
			client.TabIndex = 1;
			client.Text = "Client";
			client.UseVisualStyleBackColor = true;
			client.Click += client_Click;
			// 
			// task01
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(406, 268);
			Controls.Add(client);
			Controls.Add(server);
			Margin = new Padding(4, 5, 4, 5);
			Name = "task01";
			Text = "Exercise 1";
			FormClosed += task01_FormClosed;
			ResumeLayout(false);
		}

		#endregion

		private Button server;
		private Button client;
	}
}
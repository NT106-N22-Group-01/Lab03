namespace Lab03
{
	partial class Server_04
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
			label1 = new Label();
			serverPortTxt = new TextBox();
			serverStartButton = new Button();
			serverStopButton = new Button();
			groupBox1 = new GroupBox();
			serverChatView = new RichTextBox();
			listViewUsers = new ListView();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(83, 96);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(58, 27);
			label1.TabIndex = 0;
			label1.Text = "Port";
			// 
			// serverPortTxt
			// 
			serverPortTxt.Location = new Point(83, 154);
			serverPortTxt.Margin = new Padding(4, 6, 4, 6);
			serverPortTxt.Name = "serverPortTxt";
			serverPortTxt.Size = new Size(164, 31);
			serverPortTxt.TabIndex = 1;
			// 
			// serverStartButton
			// 
			serverStartButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			serverStartButton.Location = new Point(300, 96);
			serverStartButton.Margin = new Padding(4, 6, 4, 6);
			serverStartButton.Name = "serverStartButton";
			serverStartButton.Size = new Size(167, 96);
			serverStartButton.TabIndex = 2;
			serverStartButton.Text = "Start";
			serverStartButton.UseVisualStyleBackColor = true;
			serverStartButton.Click += serverStartButton_Click;
			// 
			// serverStopButton
			// 
			serverStopButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			serverStopButton.Location = new Point(517, 96);
			serverStopButton.Margin = new Padding(4, 6, 4, 6);
			serverStopButton.Name = "serverStopButton";
			serverStopButton.Size = new Size(167, 96);
			serverStopButton.TabIndex = 3;
			serverStopButton.Text = "Stop";
			serverStopButton.UseVisualStyleBackColor = true;
			serverStopButton.Click += serverStopButton_Click;
			// 
			// groupBox1
			// 
			groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(50, 58);
			groupBox1.Margin = new Padding(4, 6, 4, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 6, 4, 6);
			groupBox1.Size = new Size(667, 172);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Start Server";
			// 
			// serverChatView
			// 
			serverChatView.Location = new Point(50, 256);
			serverChatView.Margin = new Padding(4, 6, 4, 6);
			serverChatView.Name = "serverChatView";
			serverChatView.Size = new Size(993, 592);
			serverChatView.TabIndex = 5;
			serverChatView.Text = "";
			// 
			// listViewUsers
			// 
			listViewUsers.Location = new Point(1078, 82);
			listViewUsers.Name = "listViewUsers";
			listViewUsers.Size = new Size(347, 766);
			listViewUsers.TabIndex = 6;
			listViewUsers.UseCompatibleStateImageBehavior = false;
			// 
			// Server_04
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1450, 887);
			Controls.Add(listViewUsers);
			Controls.Add(serverChatView);
			Controls.Add(serverStopButton);
			Controls.Add(serverStartButton);
			Controls.Add(serverPortTxt);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Margin = new Padding(4, 6, 4, 6);
			Name = "Server_04";
			Text = "Server";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox serverPortTxt;
		private System.Windows.Forms.Button serverStartButton;
		private System.Windows.Forms.Button serverStopButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox serverChatView;
		private ListView listViewUsers;
	}
}


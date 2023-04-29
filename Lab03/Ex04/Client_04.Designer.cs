namespace Lab03
{
	partial class Client_04
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
			serverIPTxt = new TextBox();
			label2 = new Label();
			serverPortTxt = new TextBox();
			clientConnectButton = new Button();
			clientDisconnectButton = new Button();
			groupBox1 = new GroupBox();
			label3 = new Label();
			nameTxt = new TextBox();
			clientChatView = new RichTextBox();
			msgTxt = new TextBox();
			clientSendButton = new Button();
			groupBox2 = new GroupBox();
			listViewUsers = new ListView();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(83, 96);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(130, 27);
			label1.TabIndex = 0;
			label1.Text = "IP Address";
			// 
			// serverIPTxt
			// 
			serverIPTxt.Location = new Point(83, 154);
			serverIPTxt.Margin = new Padding(5, 6, 5, 6);
			serverIPTxt.Name = "serverIPTxt";
			serverIPTxt.Size = new Size(164, 31);
			serverIPTxt.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(317, 96);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(58, 27);
			label2.TabIndex = 2;
			label2.Text = "Port";
			// 
			// serverPortTxt
			// 
			serverPortTxt.Location = new Point(317, 154);
			serverPortTxt.Margin = new Padding(5, 6, 5, 6);
			serverPortTxt.Name = "serverPortTxt";
			serverPortTxt.Size = new Size(164, 31);
			serverPortTxt.TabIndex = 3;
			// 
			// clientConnectButton
			// 
			clientConnectButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			clientConnectButton.Location = new Point(750, 96);
			clientConnectButton.Margin = new Padding(5, 6, 5, 6);
			clientConnectButton.Name = "clientConnectButton";
			clientConnectButton.Size = new Size(150, 96);
			clientConnectButton.TabIndex = 4;
			clientConnectButton.Text = "Connect";
			clientConnectButton.UseVisualStyleBackColor = true;
			clientConnectButton.Click += clientConnectButton_Click;
			// 
			// clientDisconnectButton
			// 
			clientDisconnectButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			clientDisconnectButton.Location = new Point(950, 96);
			clientDisconnectButton.Margin = new Padding(5, 6, 5, 6);
			clientDisconnectButton.Name = "clientDisconnectButton";
			clientDisconnectButton.Size = new Size(150, 96);
			clientDisconnectButton.TabIndex = 5;
			clientDisconnectButton.Text = "Disconnect";
			clientDisconnectButton.UseVisualStyleBackColor = true;
			clientDisconnectButton.Click += clientDisconnectButton_Click;
			// 
			// groupBox1
			// 
			groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(50, 58);
			groupBox1.Margin = new Padding(5, 6, 5, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(5, 6, 5, 6);
			groupBox1.Size = new Size(1083, 154);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Connect to Server";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(533, 96);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(74, 27);
			label3.TabIndex = 7;
			label3.Text = "Name";
			// 
			// nameTxt
			// 
			nameTxt.Location = new Point(533, 154);
			nameTxt.Margin = new Padding(5, 6, 5, 6);
			nameTxt.Name = "nameTxt";
			nameTxt.Size = new Size(164, 31);
			nameTxt.TabIndex = 8;
			// 
			// clientChatView
			// 
			clientChatView.Location = new Point(50, 231);
			clientChatView.Margin = new Padding(5, 6, 5, 6);
			clientChatView.Name = "clientChatView";
			clientChatView.Size = new Size(1081, 411);
			clientChatView.TabIndex = 9;
			clientChatView.Text = "";
			// 
			// msgTxt
			// 
			msgTxt.Location = new Point(81, 723);
			msgTxt.Margin = new Padding(5, 6, 5, 6);
			msgTxt.Multiline = true;
			msgTxt.Name = "msgTxt";
			msgTxt.Size = new Size(831, 92);
			msgTxt.TabIndex = 10;
			msgTxt.TextChanged += msgTxt_TextChanged;
			// 
			// clientSendButton
			// 
			clientSendButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			clientSendButton.Location = new Point(948, 723);
			clientSendButton.Margin = new Padding(5, 6, 5, 6);
			clientSendButton.Name = "clientSendButton";
			clientSendButton.Size = new Size(150, 96);
			clientSendButton.TabIndex = 11;
			clientSendButton.Text = "Send";
			clientSendButton.UseVisualStyleBackColor = true;
			clientSendButton.Click += clientSendButton_Click;
			// 
			// groupBox2
			// 
			groupBox2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox2.Location = new Point(48, 663);
			groupBox2.Margin = new Padding(5, 6, 5, 6);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(5, 6, 5, 6);
			groupBox2.Size = new Size(1083, 173);
			groupBox2.TabIndex = 12;
			groupBox2.TabStop = false;
			groupBox2.Text = "Message";
			// 
			// listViewUsers
			// 
			listViewUsers.Location = new Point(1141, 66);
			listViewUsers.Name = "listViewUsers";
			listViewUsers.Size = new Size(328, 770);
			listViewUsers.TabIndex = 13;
			listViewUsers.UseCompatibleStateImageBehavior = false;
			// 
			// Client_04
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1481, 863);
			Controls.Add(listViewUsers);
			Controls.Add(clientSendButton);
			Controls.Add(msgTxt);
			Controls.Add(clientChatView);
			Controls.Add(nameTxt);
			Controls.Add(label3);
			Controls.Add(clientDisconnectButton);
			Controls.Add(clientConnectButton);
			Controls.Add(serverPortTxt);
			Controls.Add(label2);
			Controls.Add(serverIPTxt);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Margin = new Padding(5, 6, 5, 6);
			Name = "Client_04";
			Text = "Client";
			Load += Client_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox serverIPTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox serverPortTxt;
		private System.Windows.Forms.Button clientConnectButton;
		private System.Windows.Forms.Button clientDisconnectButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nameTxt;
		private System.Windows.Forms.RichTextBox clientChatView;
		private System.Windows.Forms.TextBox msgTxt;
		private System.Windows.Forms.Button clientSendButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private ListView listViewUsers;
	}
}


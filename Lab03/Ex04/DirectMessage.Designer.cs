namespace Lab03.Ex04
{
	partial class DirectMessage
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
			clientChatView = new RichTextBox();
			groupBox2 = new GroupBox();
			clientSendButton = new Button();
			msgTxt = new TextBox();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// clientChatView
			// 
			clientChatView.Location = new Point(33, 15);
			clientChatView.Margin = new Padding(5, 6, 5, 6);
			clientChatView.Name = "clientChatView";
			clientChatView.Size = new Size(942, 400);
			clientChatView.TabIndex = 17;
			clientChatView.Text = "";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(clientSendButton);
			groupBox2.Controls.Add(msgTxt);
			groupBox2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox2.Location = new Point(33, 442);
			groupBox2.Margin = new Padding(5, 6, 5, 6);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(5, 6, 5, 6);
			groupBox2.Size = new Size(942, 122);
			groupBox2.TabIndex = 18;
			groupBox2.TabStop = false;
			groupBox2.Text = "Message";
			// 
			// clientSendButton
			// 
			clientSendButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			clientSendButton.Location = new Point(787, 35);
			clientSendButton.Margin = new Padding(5, 6, 5, 6);
			clientSendButton.Name = "clientSendButton";
			clientSendButton.Size = new Size(126, 62);
			clientSendButton.TabIndex = 15;
			clientSendButton.Text = "Send";
			clientSendButton.UseVisualStyleBackColor = true;
			clientSendButton.Click += clientSendButton_Click;
			// 
			// msgTxt
			// 
			msgTxt.Location = new Point(10, 39);
			msgTxt.Margin = new Padding(5, 6, 5, 6);
			msgTxt.Multiline = true;
			msgTxt.Name = "msgTxt";
			msgTxt.Size = new Size(752, 58);
			msgTxt.TabIndex = 14;
			msgTxt.TextChanged += msgTxt_TextChanged;
			// 
			// DirectMessage
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1001, 581);
			Controls.Add(clientChatView);
			Controls.Add(groupBox2);
			Name = "DirectMessage";
			Text = "DirectMessage";
			FormClosing += DirectMessage_FormClosing;
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox clientChatView;
		private GroupBox groupBox2;
		private Button clientSendButton;
		private TextBox msgTxt;
	}
}
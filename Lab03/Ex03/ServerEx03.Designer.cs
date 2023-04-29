namespace Lab03.Ex03
{
	partial class ServerEx03
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
			lvMessage = new ListView();
			btnListen = new Button();
			SuspendLayout();
			// 
			// lvMessage
			// 
			lvMessage.Location = new Point(17, 20);
			lvMessage.Margin = new Padding(4, 5, 4, 5);
			lvMessage.Name = "lvMessage";
			lvMessage.Size = new Size(733, 521);
			lvMessage.TabIndex = 0;
			lvMessage.UseCompatibleStateImageBehavior = false;
			lvMessage.View = View.List;
			// 
			// btnListen
			// 
			btnListen.Location = new Point(773, 20);
			btnListen.Margin = new Padding(4, 5, 4, 5);
			btnListen.Name = "btnListen";
			btnListen.Size = new Size(119, 42);
			btnListen.TabIndex = 1;
			btnListen.Text = "Listen";
			btnListen.UseVisualStyleBackColor = true;
			btnListen.Click += btnListen_Click;
			// 
			// ServerEx03
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(909, 563);
			Controls.Add(btnListen);
			Controls.Add(lvMessage);
			Margin = new Padding(4, 5, 4, 5);
			Name = "ServerEx03";
			Text = "ServerEx03";
			FormClosing += ServerEx03_FormClosing;
			ResumeLayout(false);
		}

		#endregion

		private ListView lvMessage;
		private Button btnListen;
	}
}
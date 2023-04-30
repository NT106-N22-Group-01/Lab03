
namespace Lab03.Ex02
{
	partial class Ex02
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
			btbLis = new Button();
			listView = new ListView();
			SuspendLayout();
			// 
			// btbLis
			// 
			btbLis.Location = new Point(1162, 25);
			btbLis.Margin = new Padding(5, 6, 5, 6);
			btbLis.Name = "btbLis";
			btbLis.Size = new Size(152, 87);
			btbLis.TabIndex = 1;
			btbLis.Text = "LISTEN";
			btbLis.UseVisualStyleBackColor = true;
			btbLis.Click += btbLis_Click;
			// 
			// listView
			// 
			listView.Location = new Point(18, 115);
			listView.Margin = new Padding(3, 4, 3, 4);
			listView.Name = "listView";
			listView.Size = new Size(1292, 725);
			listView.TabIndex = 2;
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = View.List;
			// 
			// Ex02
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1333, 865);
			Controls.Add(listView);
			Controls.Add(btbLis);
			Margin = new Padding(5, 6, 5, 6);
			Name = "Ex02";
			Text = "Form1";
			FormClosed += Ex02_FormClosed;
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.Button btbLis;
		private System.Windows.Forms.ListView listView;
	}
}


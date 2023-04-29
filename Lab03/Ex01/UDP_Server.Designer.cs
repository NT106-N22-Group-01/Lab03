namespace Lab03
{
    partial class task01_udpserver
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
            portTxt = new TextBox();
            listenButton = new Button();
            viewOutput = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 0;
            label1.Text = "Port:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // portTxt
            // 
            portTxt.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            portTxt.Location = new Point(50, 80);
            portTxt.Name = "portTxt";
            portTxt.Size = new Size(150, 25);
            portTxt.TabIndex = 1;
            // 
            // listenButton
            // 
            listenButton.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listenButton.Location = new Point(365, 50);
            listenButton.Name = "listenButton";
            listenButton.Size = new Size(110, 55);
            listenButton.TabIndex = 2;
            listenButton.Text = "Listen";
            listenButton.UseVisualStyleBackColor = true;
            listenButton.Click += listenButton_Click;
            // 
            // viewOutput
            // 
            viewOutput.Location = new Point(50, 130);
            viewOutput.Name = "viewOutput";
            viewOutput.Size = new Size(425, 260);
            viewOutput.TabIndex = 3;
            viewOutput.Text = "";
            // 
            // task01_udpserver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 441);
            Controls.Add(viewOutput);
            Controls.Add(listenButton);
            Controls.Add(portTxt);
            Controls.Add(label1);
            Name = "task01_udpserver";
            Text = "UDP_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox portTxt;
        private Button listenButton;
        private RichTextBox viewOutput;
    }
}
namespace Lab03
{
    partial class task01_udpclient
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
            viewOutput = new RichTextBox();
            sendButton = new Button();
            label2 = new Label();
            label3 = new Label();
            IPTxt = new TextBox();
            msgTxt = new TextBox();
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
            // 
            // portTxt
            // 
            portTxt.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            portTxt.Location = new Point(50, 80);
            portTxt.Name = "portTxt";
            portTxt.Size = new Size(100, 25);
            portTxt.TabIndex = 1;
            // 
            // viewOutput
            // 
            viewOutput.Location = new Point(50, 130);
            viewOutput.Name = "viewOutput";
            viewOutput.Size = new Size(425, 200);
            viewOutput.TabIndex = 2;
            viewOutput.Text = "";
            // 
            // sendButton
            // 
            sendButton.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sendButton.Location = new Point(365, 350);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(110, 55);
            sendButton.TabIndex = 3;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(200, 50);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 4;
            label2.Text = "IP Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 350);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 5;
            label3.Text = "Message:";
            // 
            // IPTxt
            // 
            IPTxt.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IPTxt.Location = new Point(200, 80);
            IPTxt.Name = "IPTxt";
            IPTxt.Size = new Size(150, 25);
            IPTxt.TabIndex = 6;
           
            // 
            // msgTxt
            // 
            msgTxt.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            msgTxt.Location = new Point(50, 380);
            msgTxt.Name = "msgTxt";
            msgTxt.Size = new Size(300, 25);
            msgTxt.TabIndex = 7;
            // 
            // task01_udpclient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 441);
            Controls.Add(msgTxt);
            Controls.Add(IPTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sendButton);
            Controls.Add(viewOutput);
            Controls.Add(portTxt);
            Controls.Add(label1);
            Name = "task01_udpclient";
            Text = "UDP_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox portTxt;
        private RichTextBox viewOutput;
        private Button sendButton;
        private Label label2;
        private Label label3;
        private TextBox IPTxt;
        private TextBox msgTxt;
    }
}
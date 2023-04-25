namespace Lab03.Ex03
{
    partial class ClientEx03
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
            tbMessage=new TextBox();
            btnConnect=new Button();
            btnSend=new Button();
            btnDisconnect=new Button();
            SuspendLayout();
            // 
            // tbMessage
            // 
            tbMessage.Location=new Point(12, 12);
            tbMessage.Multiline=true;
            tbMessage.Name="tbMessage";
            tbMessage.Size=new Size(559, 317);
            tbMessage.TabIndex=0;
            tbMessage.TextChanged+=tbMessage_TextChanged;
            // 
            // btnConnect
            // 
            btnConnect.Location=new Point(591, 12);
            btnConnect.Name="btnConnect";
            btnConnect.Size=new Size(79, 28);
            btnConnect.TabIndex=1;
            btnConnect.Text="Connect";
            btnConnect.UseVisualStyleBackColor=true;
            btnConnect.Click+=btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location=new Point(591, 71);
            btnSend.Name="btnSend";
            btnSend.Size=new Size(79, 28);
            btnSend.TabIndex=2;
            btnSend.Text="Send";
            btnSend.UseVisualStyleBackColor=true;
            btnSend.Click+=btnSend_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location=new Point(591, 131);
            btnDisconnect.Name="btnDisconnect";
            btnDisconnect.Size=new Size(79, 28);
            btnDisconnect.TabIndex=3;
            btnDisconnect.Text="Disconnect";
            btnDisconnect.UseVisualStyleBackColor=true;
            btnDisconnect.Click+=btnDisconnect_Click;
            // 
            // ClientEx03
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(682, 341);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(tbMessage);
            Name="ClientEx03";
            Text="ClientEx03";
            Load+=ClientEx03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMessage;
        private Button btnConnect;
        private Button btnSend;
        private Button btnDisconnect;
    }
}
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
            server.Location = new Point(30, 50);
            server.Name = "server";
            server.Size = new Size(100, 50);
            server.TabIndex = 0;
            server.Text = "Server";
            server.UseVisualStyleBackColor = true;
            server.Click += server_Click;
            // 
            // client
            // 
            client.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            client.Location = new Point(155, 50);
            client.Name = "client";
            client.Size = new Size(100, 50);
            client.TabIndex = 1;
            client.Text = "Client";
            client.UseVisualStyleBackColor = true;
            client.Click += client_Click;
            // 
            // task01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(client);
            Controls.Add(server);
            Name = "task01";
            Text = "Task 1";
            ResumeLayout(false);
        }

        #endregion

        private Button server;
        private Button client;
    }
}
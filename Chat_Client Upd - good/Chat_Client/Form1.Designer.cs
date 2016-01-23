namespace Chat_Client
{
    partial class Form1
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
            this.bgClient1 = new System.Windows.Forms.GroupBox();
            this.gbClient2 = new System.Windows.Forms.GroupBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textFriendsIp = new System.Windows.Forms.TextBox();
            this.textFriendsPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bgClient1.SuspendLayout();
            this.gbClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgClient1
            // 
            this.bgClient1.Controls.Add(this.label2);
            this.bgClient1.Controls.Add(this.label1);
            this.bgClient1.Controls.Add(this.textLocalPort);
            this.bgClient1.Controls.Add(this.textLocalIp);
            this.bgClient1.Location = new System.Drawing.Point(44, 37);
            this.bgClient1.Name = "bgClient1";
            this.bgClient1.Size = new System.Drawing.Size(200, 100);
            this.bgClient1.TabIndex = 0;
            this.bgClient1.TabStop = false;
            this.bgClient1.Text = "Client1";
            // 
            // gbClient2
            // 
            this.gbClient2.Controls.Add(this.label4);
            this.gbClient2.Controls.Add(this.label3);
            this.gbClient2.Controls.Add(this.textFriendsPort);
            this.gbClient2.Controls.Add(this.textFriendsIp);
            this.gbClient2.Location = new System.Drawing.Point(282, 37);
            this.gbClient2.Name = "gbClient2";
            this.gbClient2.Size = new System.Drawing.Size(200, 100);
            this.gbClient2.TabIndex = 0;
            this.gbClient2.TabStop = false;
            this.gbClient2.Text = "Client2";
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(77, 28);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(100, 20);
            this.textLocalIp.TabIndex = 0;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(77, 58);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(100, 20);
            this.textLocalPort.TabIndex = 1;
            // 
            // textFriendsIp
            // 
            this.textFriendsIp.Location = new System.Drawing.Point(82, 32);
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new System.Drawing.Size(100, 20);
            this.textFriendsIp.TabIndex = 1;
            // 
            // textFriendsPort
            // 
            this.textFriendsPort.Location = new System.Drawing.Point(82, 58);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new System.Drawing.Size(100, 20);
            this.textFriendsPort.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(496, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(44, 143);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(446, 147);
            this.listMessage.TabIndex = 2;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(44, 313);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(446, 20);
            this.textMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(496, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PORT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 359);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbClient2);
            this.Controls.Add(this.bgClient1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bgClient1.ResumeLayout(false);
            this.bgClient1.PerformLayout();
            this.gbClient2.ResumeLayout(false);
            this.gbClient2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bgClient1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.GroupBox gbClient2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFriendsPort;
        private System.Windows.Forms.TextBox textFriendsIp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button btnSend;
    }
}


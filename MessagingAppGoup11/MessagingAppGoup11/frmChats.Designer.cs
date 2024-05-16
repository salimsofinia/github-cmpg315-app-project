namespace MessagingAppGoup11
{
    partial class frmChats
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblMyIp = new System.Windows.Forms.Label();
            this.lblMyPort = new System.Windows.Forms.Label();
            this.rdoPtpChat = new System.Windows.Forms.RadioButton();
            this.rdoGlobalChat = new System.Windows.Forms.RadioButton();
            this.lblSelectChat = new System.Windows.Forms.Label();
            this.btnStartChat = new System.Windows.Forms.Button();
            this.lblReceiverIp = new System.Windows.Forms.Label();
            this.lblReceiverPort = new System.Windows.Forms.Label();
            this.txtReceiverIp = new System.Windows.Forms.TextBox();
            this.txtReceiverPort = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Image = global::MessagingAppGoup11.Properties.Resources.ChatBackground;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTitle.Location = new System.Drawing.Point(10, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 91);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "WiiChat";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSend.Location = new System.Drawing.Point(391, 587);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(145, 38);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageBox.ForeColor = System.Drawing.Color.Black;
            this.txtMessageBox.Location = new System.Drawing.Point(14, 591);
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(371, 32);
            this.txtMessageBox.TabIndex = 8;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.ForeColor = System.Drawing.Color.White;
            this.lblSource.Location = new System.Drawing.Point(9, 9);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(87, 26);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(9, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(135, 26);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "lblUsername";
            // 
            // lblMyIp
            // 
            this.lblMyIp.AutoSize = true;
            this.lblMyIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyIp.ForeColor = System.Drawing.Color.White;
            this.lblMyIp.Location = new System.Drawing.Point(9, 85);
            this.lblMyIp.Name = "lblMyIp";
            this.lblMyIp.Size = new System.Drawing.Size(81, 26);
            this.lblMyIp.TabIndex = 3;
            this.lblMyIp.Text = "lblMyIp";
            // 
            // lblMyPort
            // 
            this.lblMyPort.AutoSize = true;
            this.lblMyPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyPort.ForeColor = System.Drawing.Color.White;
            this.lblMyPort.Location = new System.Drawing.Point(9, 123);
            this.lblMyPort.Name = "lblMyPort";
            this.lblMyPort.Size = new System.Drawing.Size(103, 26);
            this.lblMyPort.TabIndex = 4;
            this.lblMyPort.Text = "lblMyPort";
            // 
            // rdoPtpChat
            // 
            this.rdoPtpChat.AutoSize = true;
            this.rdoPtpChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPtpChat.ForeColor = System.Drawing.Color.White;
            this.rdoPtpChat.Location = new System.Drawing.Point(21, 46);
            this.rdoPtpChat.Name = "rdoPtpChat";
            this.rdoPtpChat.Size = new System.Drawing.Size(204, 30);
            this.rdoPtpChat.TabIndex = 5;
            this.rdoPtpChat.TabStop = true;
            this.rdoPtpChat.Text = "Peer to Peer Chat";
            this.rdoPtpChat.UseVisualStyleBackColor = true;
            this.rdoPtpChat.CheckedChanged += new System.EventHandler(this.rdoPtpChat_CheckedChanged_1);
            // 
            // rdoGlobalChat
            // 
            this.rdoGlobalChat.AutoSize = true;
            this.rdoGlobalChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGlobalChat.ForeColor = System.Drawing.Color.White;
            this.rdoGlobalChat.Location = new System.Drawing.Point(21, 87);
            this.rdoGlobalChat.Name = "rdoGlobalChat";
            this.rdoGlobalChat.Size = new System.Drawing.Size(145, 30);
            this.rdoGlobalChat.TabIndex = 6;
            this.rdoGlobalChat.TabStop = true;
            this.rdoGlobalChat.Text = "Global Chat";
            this.rdoGlobalChat.UseVisualStyleBackColor = true;
            this.rdoGlobalChat.CheckedChanged += new System.EventHandler(this.rdoGlobalChat_CheckedChanged_1);
            // 
            // lblSelectChat
            // 
            this.lblSelectChat.AutoSize = true;
            this.lblSelectChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectChat.ForeColor = System.Drawing.Color.White;
            this.lblSelectChat.Location = new System.Drawing.Point(16, 9);
            this.lblSelectChat.Name = "lblSelectChat";
            this.lblSelectChat.Size = new System.Drawing.Size(131, 26);
            this.lblSelectChat.TabIndex = 7;
            this.lblSelectChat.Text = "Select Chat:";
            // 
            // btnStartChat
            // 
            this.btnStartChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartChat.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnStartChat.Location = new System.Drawing.Point(233, 493);
            this.btnStartChat.Name = "btnStartChat";
            this.btnStartChat.Size = new System.Drawing.Size(145, 38);
            this.btnStartChat.TabIndex = 8;
            this.btnStartChat.Text = "Start Chat";
            this.btnStartChat.UseVisualStyleBackColor = false;
            this.btnStartChat.Click += new System.EventHandler(this.btnStartChat_Click_1);
            // 
            // lblReceiverIp
            // 
            this.lblReceiverIp.AutoSize = true;
            this.lblReceiverIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverIp.ForeColor = System.Drawing.Color.White;
            this.lblReceiverIp.Location = new System.Drawing.Point(16, 330);
            this.lblReceiverIp.Name = "lblReceiverIp";
            this.lblReceiverIp.Size = new System.Drawing.Size(217, 26);
            this.lblReceiverIp.TabIndex = 9;
            this.lblReceiverIp.Text = "Receiver IP Address:";
            // 
            // lblReceiverPort
            // 
            this.lblReceiverPort.AutoSize = true;
            this.lblReceiverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverPort.ForeColor = System.Drawing.Color.White;
            this.lblReceiverPort.Location = new System.Drawing.Point(16, 426);
            this.lblReceiverPort.Name = "lblReceiverPort";
            this.lblReceiverPort.Size = new System.Drawing.Size(150, 26);
            this.lblReceiverPort.TabIndex = 10;
            this.lblReceiverPort.Text = "Receiver Port:";
            // 
            // txtReceiverIp
            // 
            this.txtReceiverIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverIp.ForeColor = System.Drawing.Color.Black;
            this.txtReceiverIp.Location = new System.Drawing.Point(17, 359);
            this.txtReceiverIp.Name = "txtReceiverIp";
            this.txtReceiverIp.Size = new System.Drawing.Size(361, 32);
            this.txtReceiverIp.TabIndex = 11;
            // 
            // txtReceiverPort
            // 
            this.txtReceiverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverPort.ForeColor = System.Drawing.Color.Black;
            this.txtReceiverPort.Location = new System.Drawing.Point(17, 455);
            this.txtReceiverPort.Name = "txtReceiverPort";
            this.txtReceiverPort.Size = new System.Drawing.Size(361, 32);
            this.txtReceiverPort.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbOutput);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtMessageBox);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(721, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 637);
            this.panel1.TabIndex = 18;
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.ForeColor = System.Drawing.Color.White;
            this.rtbOutput.Location = new System.Drawing.Point(14, 14);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(522, 567);
            this.rtbOutput.TabIndex = 10;
            this.rtbOutput.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::MessagingAppGoup11.Properties.Resources.SendIcon;
            this.pictureBox2.Location = new System.Drawing.Point(497, 591);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSource);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.lblMyIp);
            this.panel2.Controls.Add(this.lblMyPort);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 165);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblReceiverPort);
            this.panel3.Controls.Add(this.rdoPtpChat);
            this.panel3.Controls.Add(this.btnStartChat);
            this.panel3.Controls.Add(this.txtReceiverIp);
            this.panel3.Controls.Add(this.txtReceiverPort);
            this.panel3.Controls.Add(this.lblReceiverIp);
            this.panel3.Controls.Add(this.rdoGlobalChat);
            this.panel3.Controls.Add(this.lblSelectChat);
            this.panel3.Location = new System.Drawing.Point(322, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 547);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MessagingAppGoup11.Properties.Resources.ChatBackground;
            this.pictureBox1.Location = new System.Drawing.Point(322, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::MessagingAppGoup11.Properties.Resources.ChatBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "frmChats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chats";
            this.Load += new System.EventHandler(this.frmChats_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Label lblMyIp;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblMyPort;
        private System.Windows.Forms.TextBox txtReceiverPort;
        private System.Windows.Forms.TextBox txtReceiverIp;
        private System.Windows.Forms.Label lblReceiverPort;
        private System.Windows.Forms.Label lblReceiverIp;
        private System.Windows.Forms.Button btnStartChat;
        private System.Windows.Forms.Label lblSelectChat;
        private System.Windows.Forms.RadioButton rdoGlobalChat;
        private System.Windows.Forms.RadioButton rdoPtpChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}
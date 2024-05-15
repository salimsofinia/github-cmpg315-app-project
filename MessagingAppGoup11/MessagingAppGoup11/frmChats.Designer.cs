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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.rdoPtpChat = new System.Windows.Forms.RadioButton();
            this.rdoGlobalChat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstConnectedUsers = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStartChat = new System.Windows.Forms.Button();
            this.lblMyPort = new System.Windows.Forms.Label();
            this.lblMyIP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtReceiverPort = new System.Windows.Forms.TextBox();
            this.txtReceiverIP = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 180);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1726, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(198, 86);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(184, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(478, 135);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "WiiChat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MessagingAppGoup11.Properties.Resources.WiiChatLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txtMessageBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 896);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 154);
            this.panel2.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1625, 9);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(249, 102);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageBox.Location = new System.Drawing.Point(128, 32);
            this.txtMessageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(1405, 53);
            this.txtMessageBox.TabIndex = 8;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(838, -40);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1066, 779);
            this.rtbOutput.TabIndex = 2;
            this.rtbOutput.Text = "";
            // 
            // rdoPtpChat
            // 
            this.rdoPtpChat.AutoSize = true;
            this.rdoPtpChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPtpChat.Location = new System.Drawing.Point(34, 32);
            this.rdoPtpChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoPtpChat.Name = "rdoPtpChat";
            this.rdoPtpChat.Size = new System.Drawing.Size(364, 50);
            this.rdoPtpChat.TabIndex = 3;
            this.rdoPtpChat.TabStop = true;
            this.rdoPtpChat.Text = "Peer to Peer Chat";
            this.rdoPtpChat.UseVisualStyleBackColor = true;
            this.rdoPtpChat.CheckedChanged += new System.EventHandler(this.rdoPtpChat_CheckedChanged);
            // 
            // rdoGlobalChat
            // 
            this.rdoGlobalChat.AutoSize = true;
            this.rdoGlobalChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGlobalChat.Location = new System.Drawing.Point(492, 32);
            this.rdoGlobalChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoGlobalChat.Name = "rdoGlobalChat";
            this.rdoGlobalChat.Size = new System.Drawing.Size(256, 50);
            this.rdoGlobalChat.TabIndex = 4;
            this.rdoGlobalChat.TabStop = true;
            this.rdoGlobalChat.Text = "Global Chat";
            this.rdoGlobalChat.UseVisualStyleBackColor = true;
            this.rdoGlobalChat.CheckedChanged += new System.EventHandler(this.rdoGlobalChat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connected Users:";
            // 
            // lstConnectedUsers
            // 
            this.lstConnectedUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConnectedUsers.FormattingEnabled = true;
            this.lstConnectedUsers.ItemHeight = 46;
            this.lstConnectedUsers.Location = new System.Drawing.Point(34, 229);
            this.lstConnectedUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstConnectedUsers.Name = "lstConnectedUsers";
            this.lstConnectedUsers.Size = new System.Drawing.Size(370, 510);
            this.lstConnectedUsers.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.btnStartChat);
            this.panel3.Controls.Add(this.lblMyPort);
            this.panel3.Controls.Add(this.lblMyIP);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.txtReceiverPort);
            this.panel3.Controls.Add(this.txtReceiverIP);
            this.panel3.Controls.Add(this.lstConnectedUsers);
            this.panel3.Controls.Add(this.rtbOutput);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rdoPtpChat);
            this.panel3.Controls.Add(this.rdoGlobalChat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1924, 716);
            this.panel3.TabIndex = 9;
            // 
            // btnStartChat
            // 
            this.btnStartChat.Location = new System.Drawing.Point(507, 409);
            this.btnStartChat.Name = "btnStartChat";
            this.btnStartChat.Size = new System.Drawing.Size(108, 39);
            this.btnStartChat.TabIndex = 14;
            this.btnStartChat.Text = "button1";
            this.btnStartChat.UseVisualStyleBackColor = true;
            this.btnStartChat.Click += new System.EventHandler(this.btnStartChat_Click);
            // 
            // lblMyPort
            // 
            this.lblMyPort.AutoSize = true;
            this.lblMyPort.Location = new System.Drawing.Point(503, 197);
            this.lblMyPort.Name = "lblMyPort";
            this.lblMyPort.Size = new System.Drawing.Size(51, 20);
            this.lblMyPort.TabIndex = 13;
            this.lblMyPort.Text = "label4";
            // 
            // lblMyIP
            // 
            this.lblMyIP.AutoSize = true;
            this.lblMyIP.Location = new System.Drawing.Point(503, 161);
            this.lblMyIP.Name = "lblMyIP";
            this.lblMyIP.Size = new System.Drawing.Size(51, 20);
            this.lblMyIP.TabIndex = 12;
            this.lblMyIP.Text = "label3";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(503, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "label2";
            // 
            // txtReceiverPort
            // 
            this.txtReceiverPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverPort.Location = new System.Drawing.Point(507, 322);
            this.txtReceiverPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiverPort.Name = "txtReceiverPort";
            this.txtReceiverPort.Size = new System.Drawing.Size(271, 53);
            this.txtReceiverPort.TabIndex = 10;
            // 
            // txtReceiverIP
            // 
            this.txtReceiverIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiverIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverIP.Location = new System.Drawing.Point(507, 235);
            this.txtReceiverIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiverIP.Name = "txtReceiverIP";
            this.txtReceiverIP.Size = new System.Drawing.Size(271, 53);
            this.txtReceiverIP.TabIndex = 9;
            // 
            // frmChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChats";
            this.Text = "Chats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.frmChats_Deactivate);
            this.Load += new System.EventHandler(this.frmChats_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.RadioButton rdoPtpChat;
        private System.Windows.Forms.RadioButton rdoGlobalChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstConnectedUsers;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtReceiverPort;
        private System.Windows.Forms.TextBox txtReceiverIP;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMyPort;
        private System.Windows.Forms.Label lblMyIP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnStartChat;
    }
}
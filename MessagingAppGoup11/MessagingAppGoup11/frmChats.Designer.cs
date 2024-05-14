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
            this.rdoPtpChat = new System.Windows.Forms.RadioButton();
            this.rdoGroupChat = new System.Windows.Forms.RadioButton();
            this.lstConnectedUsers = new System.Windows.Forms.ListBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblConnectedUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoPtpChat
            // 
            this.rdoPtpChat.AutoSize = true;
            this.rdoPtpChat.Location = new System.Drawing.Point(161, 63);
            this.rdoPtpChat.Name = "rdoPtpChat";
            this.rdoPtpChat.Size = new System.Drawing.Size(113, 17);
            this.rdoPtpChat.TabIndex = 0;
            this.rdoPtpChat.TabStop = true;
            this.rdoPtpChat.Text = "Peer To Peer Chat";
            this.rdoPtpChat.UseVisualStyleBackColor = true;
            // 
            // rdoGroupChat
            // 
            this.rdoGroupChat.AutoSize = true;
            this.rdoGroupChat.Location = new System.Drawing.Point(280, 63);
            this.rdoGroupChat.Name = "rdoGroupChat";
            this.rdoGroupChat.Size = new System.Drawing.Size(79, 17);
            this.rdoGroupChat.TabIndex = 1;
            this.rdoGroupChat.TabStop = true;
            this.rdoGroupChat.Text = "Group Chat";
            this.rdoGroupChat.UseVisualStyleBackColor = true;
            // 
            // lstConnectedUsers
            // 
            this.lstConnectedUsers.FormattingEnabled = true;
            this.lstConnectedUsers.Location = new System.Drawing.Point(12, 151);
            this.lstConnectedUsers.Name = "lstConnectedUsers";
            this.lstConnectedUsers.Size = new System.Drawing.Size(299, 446);
            this.lstConnectedUsers.TabIndex = 2;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(365, 86);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(691, 360);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(365, 491);
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(395, 20);
            this.txtMessageBox.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(837, 491);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(149, 33);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblConnectedUsers
            // 
            this.lblConnectedUsers.AutoSize = true;
            this.lblConnectedUsers.Location = new System.Drawing.Point(26, 115);
            this.lblConnectedUsers.Name = "lblConnectedUsers";
            this.lblConnectedUsers.Size = new System.Drawing.Size(92, 13);
            this.lblConnectedUsers.TabIndex = 6;
            this.lblConnectedUsers.Text = "Connected Users:";
            // 
            // frmChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 605);
            this.Controls.Add(this.lblConnectedUsers);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lstConnectedUsers);
            this.Controls.Add(this.rdoGroupChat);
            this.Controls.Add(this.rdoPtpChat);
            this.Name = "frmChats";
            this.Text = "Chats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoPtpChat;
        private System.Windows.Forms.RadioButton rdoGroupChat;
        private System.Windows.Forms.ListBox lstConnectedUsers;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblConnectedUsers;
    }
}
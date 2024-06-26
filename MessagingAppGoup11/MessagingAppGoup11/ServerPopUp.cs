﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MessagingAppGoup11
{
    public partial class ServerPopUp : Form
    {
        public ServerPopUp(string serverType)
        {
            InitializeComponent();
            this.serverType = serverType;
        }

        public string ServerIp { get; set; }
        public int ServerPort { get; set; }

        string serverType = string.Empty;

        private void ServerPopUp_Load(object sender, EventArgs e)
        { 
            lblHeading.Text = "Enter " + serverType + " IP Address and Port:";
            txtServerPort.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!String.IsNullOrWhiteSpace(txtServerIp.Text) && (!String.IsNullOrWhiteSpace(txtServerPort.Text))))
                {
                    ServerIp = txtServerIp.Text;
                    ServerPort = Convert.ToInt32(txtServerPort.Text);
                    this.Close();
                }
                else if (String.IsNullOrWhiteSpace(txtServerIp.Text))
                {
                    errorProvider1.SetError(txtServerIp, "Invalid Server IP.");
                    txtServerIp.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtServerPort, "Invalid Server Port.");
                    txtServerPort.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

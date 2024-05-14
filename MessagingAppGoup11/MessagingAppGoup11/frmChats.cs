using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MessagingAppGoup11
{
    public partial class frmChats : Form
    {
        public frmChats()
        {
            InitializeComponent();
        }

        public string ServerIp { get; set; }
        public int ServerPort { get; set; }

        private void frmChats_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoPtpChat_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

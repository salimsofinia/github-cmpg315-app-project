﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingAppGoup11
{
    public partial class frmChats : Form
    {
        public frmChats()
        {
            InitializeComponent();
        }

        private void frmChats_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

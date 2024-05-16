using System;
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
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        public string Username { get; set; }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    // Save the username
                    Username = txtUsername.Text;

                    // Create instance of Chats form, pass the username, and show
                    frmChats chatsForm = new frmChats(Username);
                    this.Hide();
                    chatsForm.ShowDialog();
                }
                else
                {
                    // Show error provider
                    errorProvider1.SetError(txtUsername, "A username is required!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblUsername_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJoinWiiChat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    // Save the username
                    Username = txtUsername.Text;

                    // Create instance of Chats form, pass the username, and show
                    frmChats chatsForm = new frmChats(Username);
                    this.Hide();
                    chatsForm.ShowDialog();
                }
                else
                {
                    // Show error provider
                    errorProvider1.SetError(txtUsername, "A username is required!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

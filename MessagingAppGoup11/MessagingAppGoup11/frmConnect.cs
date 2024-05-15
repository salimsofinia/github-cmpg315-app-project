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

        public string username = "";

        private void frmConnect_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblHelp.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    // Save the username
                    username = txtUsername.Text;

                    // Create instance of Chats form, pass the username, and show
                    frmChats chatsForm = new frmChats(username);
                    this.Hide();
                    chatsForm.ShowDialog();
                    this.Show(); // Show this form again after closing frmChats if needed
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

        private void lblUsername_MouseHover(object sender, EventArgs e)
        {
            //lblHelp.Show();
        }

        private void lblUsername_MouseMove(object sender, MouseEventArgs e)
        {
            lblHelp.Show();
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblHelp.Hide();
        }

        private void lblUsername_MouseLeave(object sender, EventArgs e)
        {
            lblHelp.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

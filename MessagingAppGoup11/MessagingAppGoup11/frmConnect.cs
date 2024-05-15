using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MessagingAppGoup11
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        public string username { get; set; }
        private void frmConnect_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblHelp.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    username = txtUsername.Text;
                    //create instance of Chats form and show
                    frmChats chatsForm = new frmChats();
                    this.Hide();
                    chatsForm.ShowDialog();
                }
                else
                {
                    //show error provider
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

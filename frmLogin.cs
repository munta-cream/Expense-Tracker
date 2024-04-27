using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_MUNTAKIM_BIN_HOSSAIN_P00194964
{
    public partial class frmLogin : Form
    {
        ExpenseTrackerEntities db = new ExpenseTrackerEntities();
        public frmLogin()
        {
            InitializeComponent();
        }


        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0 && txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter username and password !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter username !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            else if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter Password !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var data = db.tblUsers.Where(u => u.Username == txtUserName.Text && u.Password == txtPassword.Text).FirstOrDefault();

            if (data != null)
            {
                this.Hide();

                userClass.uId = data.uId;
                userClass.FullName = data.FullName;
                userClass.Username = data.Username;
                userClass.UserType = data.UserType;
                userClass.UserType = "Customer";
                frmMainMenu frm = new frmMainMenu();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid User !!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkViewpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewpass.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

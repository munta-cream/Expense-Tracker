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
    public partial class frmRegister : Form
    {
        ExpenseTrackerEntities db = new ExpenseTrackerEntities();

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (txtFullName.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Fullname");
            }

            if (txtUserName.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Username");
            }  

             if (txtPassword.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Username");
            }

             if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                sb.AppendLine("Sorry, Password and Confirm Password does not match !!");
            }

            // Check if password is at least 8 characters long and contains
            // at least one lowercase and one uppercase letter
            string password = txtPassword.Text;
            bool validPassword = password.Length >= 8
                && password.Any(char.IsLower)
                && password.Any(char.IsUpper);

            if (!validPassword)
            {
                sb.AppendLine("Password is not valid");
            }

            if (sb.ToString() != String.Empty)
               
                {
                MessageBox.Show(sb.ToString());
                return;
                }
            tblUser user = new tblUser();
            user.FullName = txtFullName.Text;
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.UserType = "Consumer";

            db.tblUsers.Add(user);
            db.SaveChanges();
            MessageBox.Show("Signup Completed Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

       

        private void chkViewpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewpass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

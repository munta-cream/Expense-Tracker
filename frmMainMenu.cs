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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusWelcome.Text = "Welcome:" + userClass.Username + ", User Type: " + userClass.UserType;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusWelcome.Text = "Welcome:" + userClass.Username + ", User Type: " + userClass.UserType;
            openChildForm(new frmHome());
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;    
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer());
        }

     
        private void btnExpensecategory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExpenseCategory());
        }

        private void btnExpenseitem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExpenseItem());
        }

        private void btnBarchart_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewchart());
        }

        private void btnExpenserecord_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExpenseRecord());
        }

        private void btnManagerUse_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserInfo());
        }
    }  
}

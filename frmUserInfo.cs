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
    public partial class frmUserInfo : Form
    {
        ExpenseTrackerEntities db = new ExpenseTrackerEntities();
        public frmUserInfo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "uId";
            gv.Columns[1].DataPropertyName = "Username";
            gv.Columns[2].DataPropertyName = "Password";
            gv.Columns[3].DataPropertyName = "FullName";
            gv.Columns[4].DataPropertyName = "UserType";


            var data = db.tblUsers.Select(x => new { x.uId, x.Username, x.Password, x.FullName, x.UserType }).ToList();
            gv.DataSource = data;

            pnlData.Visible = false;
        }
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            LoadData();
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 5:
                        pnlData.Visible = true;
                        btnInsert.Text = "Update";
                        txtId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtId.Text);

                        var data = db.tblUsers.Where(x => x.uId == idn).FirstOrDefault();
                        //MessageBox.Show(data.TransId.ToString());

                        txtUserName.Text = data.Username;
                        txtPassword.Text = data.Password;
                        txtFullName.Text = data.FullName;
                        cmbUserType.Text = data.UserType;


                        break;

                    default:

                    case 6:
                        txtId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtId.Text);

                        var datadelete = db.tblAccounts.Where(x => x.aId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Do you wish to delete?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            db.tblAccounts.Remove(datadelete);
                            db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Data deleted successfully");
                        }
                        break;
                }

            }
            catch (Exception)
            {


            }
        }

        private void clearUserForm()
        {
            txtId.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            cmbUserType.SelectedIndex = 0;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert";
            pnlData.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearUserForm();
            pnlData.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text == "Insert")
            {
                tblUser user = new tblUser();

                user.Username = txtUserName.Text;
                user.Password = txtPassword.Text;
                user.FullName = txtFullName.Text;
                user.UserType = cmbUserType.Text;


                db.tblUsers.Add(user);
                db.SaveChanges();

                clearUserForm();
                MessageBox.Show("Data Saved Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            else
            {

                //update code 
                int idn = Int32.Parse(txtId.Text);
                var user = db.tblUsers.Where(x => x.uId == idn).FirstOrDefault();
                if (user != null)
                {
                    user.Username = txtUserName.Text;
                    user.Password = txtPassword.Text;
                    user.FullName = txtFullName.Text;
                    user.UserType = cmbUserType.Text;


                    db.SaveChanges();
                    LoadData();
                    btnInsert.Text = "Insert";

                }


                clearUserForm();
                MessageBox.Show("Data Updated Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}

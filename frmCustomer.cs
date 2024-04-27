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
    public partial class frmCustomer : Form
    {
        ExpenseTrackerEntities db = new ExpenseTrackerEntities();
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            gV.AutoGenerateColumns = false;
            gV.Columns[0].DataPropertyName = "cId";
            gV.Columns[1].DataPropertyName = "Name";
            gV.Columns[2].DataPropertyName = "Email";
            gV.Columns[3].DataPropertyName = "Phone";
            gV.Columns[4].DataPropertyName = "userName";

            var data = db.tblCustomers.Select(x => new { x.cId, x.Name, x.Email, x.Phone, userName= x.tblUser.Username }).ToList();
            gV.DataSource=data;


        }
        private void clearForm()
        {
            txtCustomerid.Text = "";
            txtCustomeremail.Text = "";
            txtCustomername.Text = "";
            txtPhonenumber.Text = "";
        
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
             LoadData();
            pnlData.Visible = false;    
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (txtCustomername.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Fullname");
            }

            if (txtCustomeremail.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Email");
            }

            if (txtPhonenumber.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Phone Number");
            }

        

            if (sb.ToString() != String.Empty)

            {
                MessageBox.Show(sb.ToString());
                return;
            }

            if (btnInsert.Text == "Insert")
            {
                tblCustomer cust = new tblCustomer();
                cust.Name = txtCustomername.Text;
                cust.Email = txtCustomeremail.Text;
                cust.Phone = txtPhonenumber.Text;
                //cust.uId = Int32.Parse(txtUser.Text);
                cust.uId = userClass.uId;

                db.tblCustomers.Add(cust);
                db.SaveChanges();
                MessageBox.Show("Data Saved Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int idn = Int32.Parse(txtCustomerid.Text);
                var cust = db.tblCustomers.Where(x => x.cId == idn).FirstOrDefault();
                if(cust != null)
                {
                    cust.Name=txtCustomername.Text;
                    cust.Email=txtCustomeremail.Text;
                    cust.Phone=txtPhonenumber.Text;


                    db.SaveChanges();
                    
                    btnInsert.Text = "Insert"; 
                }
                MessageBox.Show("Data Saved Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            //End of Else
            LoadData();

            clearForm();
            pnlData.Visible = false;
        }//End of Events
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 5:
                        pnlData.Visible = true;
                        btnInsert.Text = "Update";
                        txtCustomerid.Text = gV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtCustomerid.Text);
                       
                        var data = db.tblCustomers.Where(x => x.cId == idn).FirstOrDefault();
                        
                        txtCustomername.Text = data.Name;
                        txtCustomeremail.Text = data.Email;
                        txtPhonenumber.Text = data.Phone;   
                        
                        break;
                    case 6:
                        txtCustomerid.Text = gV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtCustomerid.Text);
                        
                        var datadelete = db.tblCustomers.Where(x => x.cId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Do you wish to delete?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            db.tblCustomers.Remove(datadelete);
                            db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Data Deleted Successfully");
                        }
                        break;
                        default:
                        break;
                }
                //End of switch
                
            }
            catch (Exception)
            {

            }
            //End of try 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clearForm();
            pnlData.Visible = false;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            pnlData.Visible = true;
            btnInsert.Text = "Insert";
        }
    }
    
}

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
    public partial class frmExpenseItem : Form
    {
        ExpenseTrackerEntities db = new ExpenseTrackerEntities();

        public frmExpenseItem()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            // Populate Combo box data
            var cbodata = db.tblExpenseCategories.ToList();
            cboExpensecategory.DataSource = cbodata;
            cboExpensecategory.DisplayMember = "CategoryName";
            cboExpensecategory.ValueMember = "ecId";


            gV.AutoGenerateColumns = false;
            gV.Columns[0].DataPropertyName = "eiId";
            gV.Columns[1].DataPropertyName = "ItemName";
            gV.Columns[2].DataPropertyName = "Cost";
            gV.Columns[3].DataPropertyName = "ItemDescription";
            gV.Columns[4].DataPropertyName = "ecId";


            var data = db.tblExpenseItems.Select(x => new { x.ecId, x.ItemName, x.Cost, x.Description, x.eiId, x.uId }).ToList();
            gV.DataSource = data;
        }



        private void clearForm()
        {
            txtItemid.Text = "";
            txtItemname.Text = "";
            txtCost.Clear();
            txtItemdescription.Clear();
            cboExpensecategory.SelectedIndex = 0;


        }
        private void gV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 5:
                        pnlData.Visible = true;
                        btnInsert.Text = "Update";
                        txtItemid.Text = gV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtItemid.Text);

                        var data = db.tblExpenseItems.Where(x => x.eiId == idn).FirstOrDefault();
                        //MessageBox.Show(data.TransId.ToString());

                        txtItemname.Text = data.ItemName;

                        break;


                    
                    case 6:
                        txtItemid.Text = gV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtItemid.Text);

                        var datadelete = db.tblExpenseItems.Where(x => x.eiId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Are you sure you want to delete?", "Delete confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            db.tblExpenseItems.Remove(datadelete);
                            db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Data has been successfully deleted");
                        }
                        break;

                    

                    default:
                        break;

                }
            }
            catch (Exception)
            {


            }
        }

        private void frmExpenseItem_Load(object sender, EventArgs e)
        {
            LoadData();
             
            pnlData.Visible = false;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert";
            pnlData.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clearForm();
            pnlData.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            if (txtItemname.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please enter the Item name!");
            }

            if (txtCost.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please enter the Item cost!");
            }

            if (txtItemdescription.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please enter the Item Description!");
            }


            if (btnInsert.Text == "Insert")
            {

                tblExpenseItem eitem = new tblExpenseItem();
                eitem.ItemName = txtItemname.Text;
                eitem.Cost = decimal.Parse(txtCost.Text);
                eitem.Description = txtItemdescription.Text;
                eitem.ecId = Int32.Parse( cboExpensecategory.SelectedValue.ToString());
                eitem.uId = 1; // userClass.uId;


                db.tblExpenseItems.Add(eitem);
                db.SaveChanges();
                MessageBox.Show("Data saved successfully!", "Insert", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();
            }
            else
            {
                //Update code
                int idn = Int32.Parse(txtItemid.Text);
                var eitem = db.tblExpenseItems.Where(x => x.eiId == idn).FirstOrDefault();
                if (eitem != null)
                {
                    eitem.ItemName = txtItemname.Text;
                    eitem.Cost = decimal.Parse(txtCost.Text);
                    eitem.Description = txtItemdescription.Text;
                    eitem.ecId = Int32.Parse(cboExpensecategory.SelectedValue.ToString());
                    eitem.uId = userClass.uId;

                    db.SaveChanges();
                    LoadData();
                    btnInsert.Text = "Insert";
                }
                MessageBox.Show("Data updated Successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            clearForm();
            LoadData();
            pnlData.Visible = false;

        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

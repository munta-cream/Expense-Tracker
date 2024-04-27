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
    public partial class frmExpenseRecord : Form
    {
        ExpenseTrackerEntities db = new ExpenseTrackerEntities();
        public frmExpenseRecord()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "erId";
            gv.Columns[1].DataPropertyName = "MonthName";
            gv.Columns[2].DataPropertyName = "CategoryName";
            gv.Columns[3].DataPropertyName = "PaymentTypeName";
            gv.Columns[4].DataPropertyName = "Cost";
            gv.Columns[5].DataPropertyName = "ItemName";

            var data = db.tblExpenseRecords.Select(x => new { x.erId, x.tblMonth.MonthName, x.tblExpenseCategory.CategoryName, x.tblPaymentType.PaymentTypeName, x.Cost, x.Description, x.tblExpenseItem.ItemName }).ToList();
            gv.DataSource = data;

            pnlData.Visible = false;


        }

        private void clearUserForm()
        {
            txtId.Text = "";
            txtCost.Text = "0";


        }


        private void frmExpenseRecord_Load(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            LoadData();

            ////Load Expense Item
            //var data = db.tblExpenseItems.ToList();
            //cboItem.DisplayMember = "ItemName";
            //cboItem.ValueMember = "eiId";
            //cboItem.DataSource = data;

            //Check ComboBox Data
            //if (data.Count == 0)
            //{
            //    MessageBox.Show("Please Add Some Expense Item Information");
            //    //this.Close();
            //    frmExpenseItem frm = new frmExpenseItem();
            //    frm.ShowDialog();
            //}

            //Load Month
            var dataMonth = db.tblMonths.ToList();
            cboMonth.DisplayMember = "MonthName";
            cboMonth.ValueMember = "Id";
            cboMonth.DataSource = dataMonth;

            //Load Category
            var dataCat = db.tblExpenseCategories.ToList();
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "ecId";
            cboCategory.DataSource = dataCat;

            //Load Payment Type
            var dataPaytype = db.tblPaymentTypes.ToList();
            cboPaymentType.DisplayMember = "PaymentTypeName";
            cboPaymentType.ValueMember = "Id";
            cboPaymentType.DataSource = dataPaytype;
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 6:
                        pnlData.Visible = true;
                        btnInsert.Text = "Update";
                        txtId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtId.Text);

                        var record = db.tblExpenseRecords.Where(x => x.erId == idn).FirstOrDefault();
                        //MessageBox.Show(data.TransId.ToString());

                        //record.UserId = userClass.uId;
                        cboMonth.SelectedValue = record.MonthId;
                        cboCategory.SelectedValue = record.ecId;
                        cboPaymentType.SelectedValue = record.PaymentTypeId;
                        txtCost.Text = record.Cost.ToString();
                        txtDescription.Text = record.Description;
                        cboItemName.SelectedValue = record.expitemId;

                        break;

                    default:

                    case 7:
                        txtId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtId.Text);

                        var datadelete = db.tblExpenseRecords.Where(x => x.erId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Do you wish to delete?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            db.tblExpenseRecords.Remove(datadelete);
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text == "Insert")
            {
                tblExpenseRecord record = new tblExpenseRecord();

                record.UserId = userClass.uId;
                record.MonthId = Int32.Parse(cboMonth.SelectedValue.ToString());
                record.ecId = Int32.Parse(cboCategory.SelectedValue.ToString());
                record.PaymentTypeId = Int32.Parse(cboPaymentType.SelectedValue.ToString());
                record.Cost = decimal.Parse(txtCost.Text);
                record.Description = txtDescription.Text;
                record.expitemId = Int32.Parse(cboItemName.SelectedValue.ToString());



                db.tblExpenseRecords.Add(record);
                db.SaveChanges();

                clearUserForm();
                MessageBox.Show("Data Saved Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            else
            {

                //update code 
                int idn = Int32.Parse(txtId.Text);
                var record = db.tblExpenseRecords.Where(x => x.erId == idn).FirstOrDefault();
                if (record != null)
                {
                    //record.UserId = userClass.uId;
                    record.MonthId = Int32.Parse(cboMonth.SelectedValue.ToString());
                    record.ecId = Int32.Parse(cboCategory.SelectedValue.ToString());
                    record.PaymentTypeId = Int32.Parse(cboPaymentType.SelectedValue.ToString());
                    record.Cost = decimal.Parse(txtCost.Text);
                    record.Description = txtDescription.Text;
                    record.expitemId = Int32.Parse(cboItemName.SelectedValue.ToString());

                    db.SaveChanges();
                    LoadData();
                    btnInsert.Text = "Insert";

                }


                clearUserForm();
                MessageBox.Show("Data Updated Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clearUserForm();
            pnlData.Visible = false;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert";
            pnlData.Visible = true;
            clearUserForm();
        }

        private void cboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Load Payment Type
            int cid = Int32.Parse(cboCategory.SelectedValue.ToString());
            var dataItem = db.tblExpenseItems.Where(x => x.ecId == cid).ToList();
            cboItemName.DisplayMember = "ItemName";
            cboItemName.ValueMember = "eiId";
            cboItemName.DataSource = dataItem;
        }

        private void cboItemName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int iid = Int32.Parse(cboItemName.SelectedValue.ToString());
            var dataItem = db.tblExpenseItems.Where(x => x.eiId == iid).FirstOrDefault();

            if (dataItem != null)
            {
                txtCost.Text = dataItem.Cost.ToString();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
    
}

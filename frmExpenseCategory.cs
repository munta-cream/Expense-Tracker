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
    public partial class frmExpenseCategory : Form
    {
        ExpenseTrackerEntities db = new ExpenseTrackerEntities();

        public frmExpenseCategory()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            gV.AutoGenerateColumns = false;
            gV.Columns[0].DataPropertyName = "ecId";
            gV.Columns[1].DataPropertyName = "CategoryName";


            var data = db.tblExpenseCategories.Select(x => new { x.ecId, x.CategoryName }).ToList();
            gV.DataSource = data;
        }

      

        private void clearForm()
        {
            txtCategoryid.Text = "";
            txtCategoryname.Text = "";


        }

      

        private void gV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 2:
                        pnlData.Visible = true;
                        btnInsert.Text = "Update";
                        txtCategoryid.Text = gV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtCategoryid.Text);

                        var data = db.tblExpenseCategories.Where(x => x.ecId == idn).FirstOrDefault();
                        //MessageBox.Show(data.TransId.ToString());

                        txtCategoryname.Text = data.CategoryName;

                        break;

                    case 3:
                        txtCategoryid.Text = gV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtCategoryid.Text);

                        var datadelete = db.tblExpenseCategories.Where(x => x.ecId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Do you want to delete?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            db.tblExpenseCategories.Remove(datadelete);
                            db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Data deleted successfully");
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

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert";
            pnlData.Visible = true;
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            if (txtCategoryname.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Category Name!!!");
            }


            if (sb.ToString() != String.Empty)
            {
                MessageBox.Show(sb.ToString());
                return;
            }

            if (btnInsert.Text == "Insert")
            {

                tblExpenseCategory cate = new tblExpenseCategory();
                cate.CategoryName = txtCategoryname.Text;
                cate.UserId = userClass.uId;

                db.tblExpenseCategories.Add(cate);
                db.SaveChanges();
                MessageBox.Show("Data Saved Successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            else
            {
                //Update code
                int idn = Int32.Parse(txtCategoryid.Text);
                var cate = db.tblExpenseCategories.Where(x => x.ecId == idn).FirstOrDefault();
                if (cate != null)
                {
                    cate.CategoryName = txtCategoryname.Text;
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            clearForm();
            pnlData.Visible = false;
        }

        private void frmExpenseCategory_Load_1(object sender, EventArgs e)
        {
            LoadData();
            pnlData.Visible = false;
        }

        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

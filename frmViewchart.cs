using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Windows.Forms.DataVisualization.Charting; 

namespace MD_MUNTAKIM_BIN_HOSSAIN_P00194964
{
    public partial class frmViewchart : Form
    {
        ExpenseTrackerEntities db = new ExpenseTrackerEntities();

        public frmViewchart()
        {
            InitializeComponent();
        }





        private void loadUserName()
        {
            lblUserName.Text = userClass.Username;
        }


        private void frmViewchart_Load(object sender, EventArgs e)
        {
            loadUserName();
            btn3D.Text = "View 3D";
            CreateChart();
        }

        private void barChart_Click(object sender, EventArgs e)
        {

        }

        private void CreateChart()
        {
            ExpenseTrackerEntities db = new ExpenseTrackerEntities();

            // Load Expense Record By User 
            var data = db.tblExpenseRecords.Where(x => x.UserId == userClass.uId).Select(x => new
            {
                x.tblMonth.MonthName,
                x.tblExpenseCategory.CategoryName,
                x.Cost
            }).ToList();



            // Data grup by month and category
            var groupData = data.GroupBy(d => new { Month = d.MonthName, Category = d.CategoryName })
                                                   .OrderBy(g => g.Key.Month)
                                                   .ThenBy(g => g.Key.Category)
                                                   .Select(g => new
                                                   {
                                                       MonthName = g.Key.Month,
                                                       Category = g.Key.Category,
                                                       TotalCost = g.Sum(x => x.Cost)
                                                   });

            // Clear existing series in the chart
            //barChart.Series.Clear();

            gv.DataSource = groupData.ToList();

            var categoryList = groupData.Select(g => g.Category).Distinct();

            foreach (var item in groupData)
            {
                barChart.Series["Series1"].Points.AddXY(item.MonthName, item.TotalCost);
                //chart1.Series["Series1"].Points[0].Color = Color.PaleGreen;
            }


            Color[] barColors = new Color[11]{
                 Color.Red,
                Color.Green,
                Color.Blue,
                Color.Red,
                Color.Purple,
                Color.SteelBlue,
                Color.Aqua,
                Color.Yellow,
                Color.Navy,
                Color.Green,
                Color.Blue

            };


            for (int i = 0; i < data.Count; i++)
            {
                barChart.Series["Series1"].Points[i].Color = barColors[i];
            }


            Title title = barChart.Titles.Add("Monthly Expense Breakdown by Category");
            title.Font = new Font(title.Font.FontFamily, 14, FontStyle.Bold);

            //chart1.Titles.Clear();
            //chart1.Titles.Add("Monthly Expense Breakdown by Category");
            barChart.Series[0].ChartType = SeriesChartType.Column;
            barChart.Legends[0].Enabled = false;
            barChart.ChartAreas[0].Area3DStyle.Enable3D = false;
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn3D_Click(object sender, EventArgs e)
        {
            barChart.ChartAreas[0].Area3DStyle.Enable3D = !barChart.ChartAreas[0].Area3DStyle.Enable3D;
            btn3D.Text = (btn3D.Text == "View 3D") ? "View 2D" : "View 3D";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            barChart.Refresh();
        }
    }
}

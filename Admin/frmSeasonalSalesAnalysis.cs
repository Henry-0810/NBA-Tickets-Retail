using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmSeasonalSalesAnalysis : Form
    {
        private static new Form Parent;
        public frmSeasonalSalesAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnYRAback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void frmYearlyRevenueAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        //Generates a chart with information from the query below
        //Get statistics - most sales match, least sales match, average sales per match and total sales per season
        private void frmSeasonalSalesAnalysis_Load(object sender, EventArgs e)
        {
            chartSales.Titles.Add("Sales analysis chart");
            chartSales.Titles[0].Font = new Font("Calibri", 16, FontStyle.Bold);
            chartSales.ChartAreas[0].BackColor = Color.DimGray;
            chartSales.ChartAreas[0].AxisX.Title = "Match ID";
            chartSales.ChartAreas[0].AxisY.Title = "Total Sales (€)";
            chartSales.ChartAreas[0].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            chartSales.ChartAreas[0].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);

            chartSales.DataSource = loadChart().Tables[0];
            chartSales.DataBind();

            int matchIdCount = loadChart().Tables[0].Rows.Count;
            chartSales.ChartAreas[0].AxisX.Interval = Math.Max(1, matchIdCount / 10);

            chartSales.Series["Total Sales"].XValueMember = "Match_ID";
            chartSales.Series["Total Sales"].YValueMembers = "Total_Sales_Match";
            chartSales.Series["Total Sales"].IsValueShownAsLabel = true;

            chartSales.Series["Total Sales"].Font = new Font("Calibri", 10);
            chartSales.Series["Total Sales"].LabelFormat = "#,##0.#0";
            chartSales.Series["Total Sales"].LabelForeColor = Color.Black;

            chartSales.Series["Total Sales"]["PointWidth"] = "0.5";
            chartSales.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartSales.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartSales.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartSales.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            getStats();
            
        }

        //This method loads the chart
        private DataSet loadChart()
        {
            OracleConnection conn = Program.getOracleConnection();

            //Gets the total sales per match by calculating the sum of total sales of sales_ID that starts with S and deducting the sum of sales_ID that starts with R
            string sqlQuery = @"SELECT DISTINCT COALESCE(sa.Match_ID, m.Match_ID) AS Match_ID, 
                                  SUM(CASE WHEN sa.Sales_ID LIKE 'S%' THEN sa.Total_Sales ELSE 0 END) -
                                  SUM(CASE WHEN sa.Sales_ID LIKE 'R%' THEN sa.Total_Sales ELSE 0 END) AS Total_Sales_Match
                              FROM Matches m
                              LEFT JOIN Sales sa ON sa.Match_ID = m.Match_ID
                              GROUP BY COALESCE(sa.Match_ID, m.Match_ID)
                              ORDER BY Match_ID";
            DataSet ds = new DataSet();
            OracleDataAdapter adapt = new OracleDataAdapter(sqlQuery, conn);
            adapt.Fill(ds);
            return ds;
        }

        //This method gets the most sales match, least sales match, average sales per match and total sales per season and display them in textboxes
        private void getStats()
        {
            string mostSalesMatchID = "";
            decimal mostSales = decimal.MinValue;
            string leastSalesMatchID = "";
            decimal leastSales = decimal.MaxValue;
            decimal totSales = 0;

            foreach (DataRow row in loadChart().Tables[0].Rows)
            {
                decimal sales = Convert.ToDecimal(row["Total_Sales_Match"]);
                if(sales > mostSales)
                {
                    mostSales = sales;
                    mostSalesMatchID = row["Match_ID"].ToString();
                }
                if(sales < leastSales)
                {
                    leastSales = sales;
                    leastSalesMatchID = row["Match_ID"].ToString();
                }
                totSales += sales;
            }
            int numOfRows = loadChart().Tables[0].Rows.Count;
            float avgSales = (float)(totSales / numOfRows);
            txtMostSales.Text = $"{mostSalesMatchID} - €{mostSales:N2}";
            txtLeastSales.Text = $"{leastSalesMatchID} - €{leastSales:N2}";
            txtAvgSales.Text = $"The average sales for {numOfRows} Matches is €{avgSales:N2}";
            txtSumOfSales.Text = $"€{totSales:N2}";
        }
    }
}

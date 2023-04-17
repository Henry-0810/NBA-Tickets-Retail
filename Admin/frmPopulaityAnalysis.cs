using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmPopulaityAnalysis : Form
    {
        private static new Form Parent;
        public frmPopulaityAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnSAback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void frmSeatsSoldperMatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void frmPopulaityAnalysis_Load(object sender, EventArgs e)
        {
            chartPopularity.Titles.Add("Popularity analysis chart");
            chartPopularity.Titles[0].Font = new Font("Calibri", 16, FontStyle.Bold);
            chartPopularity.ChartAreas[0].BackColor = Color.LightGray;
            chartPopularity.ChartAreas[0].AxisX.Title = "Seat Type";
            chartPopularity.ChartAreas[0].AxisY.Title = "Purchased Count";
            chartPopularity.ChartAreas[0].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            chartPopularity.ChartAreas[0].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);

            chartPopularity.DataSource = loadChart().Tables[0];
            chartPopularity.DataBind();

            int seatTypeCount = loadChart().Tables[0].Rows.Count;
            chartPopularity.ChartAreas[0].AxisX.Interval = Math.Max(1, seatTypeCount / 10);

            chartPopularity.Series["No. of times purchased"].XValueMember = "Seat_Type";
            chartPopularity.Series["No. of times purchased"].YValueMembers = "Popularity";
            chartPopularity.Series["No. of times purchased"].IsValueShownAsLabel = true;

            chartPopularity.Series["No. of times purchased"].LabelForeColor = Color.Black;

            chartPopularity.Series["No. of times purchased"]["PointWidth"] = "0.5";
            chartPopularity.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartPopularity.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartPopularity.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartPopularity.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }

        private DataSet loadChart()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = @"SELECT st.Type_Code AS Seat_Type, COUNT(*) AS Popularity FROM SeatTypes st
                              INNER JOIN Seats s ON s.Type_Code = st.Type_Code
                              INNER JOIN MatchSeats ms ON ms.Seat_Num = s.Seat_Num
                              INNER JOIN Matches m ON m.Match_ID = ms.Match_ID
                              INNER JOIN Sales sa ON sa.Match_ID = ms.Match_ID
                              INNER JOIN SaleSeats ss ON ss.Sales_ID = sa.Sales_ID AND ss.Seat_Num = ms.Seat_Num
                              GROUP BY st.Type_Code
                              ORDER BY st.Type_Code";

            DataSet ds = new DataSet();
            OracleDataAdapter adapt = new OracleDataAdapter(sqlQuery, conn);
            adapt.Fill(ds);
            return ds;
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmPopulaityAnalysis : Form
    {
        private OracleConnection conn = Program.getOracleConnection();
        private static new Form Parent;
        private string loadQuery = @"SELECT st.Type_Code AS Seat_Type, 
                                       COUNT(ss.Seat_Num) AS Bought_Count, 
                                       tc.Total_Count AS Total_Count,
                                       (COUNT(ss.Seat_Num) / tc.Total_Count * 100) AS Popularity
                                FROM SeatTypes st
                                INNER JOIN Seats s ON s.Type_Code = st.Type_Code
                                LEFT JOIN MatchSeats ms ON ms.Seat_Num = s.Seat_Num
                                LEFT JOIN Matches m ON m.Match_ID = ms.Match_ID
                                LEFT JOIN Sales sa ON sa.Match_ID = ms.Match_ID
                                LEFT JOIN SaleSeats ss ON ss.Sales_ID = sa.Sales_ID AND ss.Seat_Num = ms.Seat_Num
                                LEFT JOIN (SELECT s.Type_Code, COUNT(ms.Seat_Num) AS Total_Count
                                           FROM Seats s LEFT JOIN MatchSeats ms ON s.Seat_Num = ms.Seat_Num
                                           GROUP BY s.Type_Code) tc ON tc.Type_Code = st.Type_Code
                                GROUP BY st.Type_Code, tc.Total_Count
                                ORDER BY st.Type_Code";
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
            chartPopularity.ChartAreas[0].BackColor = Color.DimGray;
            chartPopularity.ChartAreas[0].AxisX.Title = "Seat Type";
            chartPopularity.ChartAreas[0].AxisY.Title = "Purchased Count";
            chartPopularity.ChartAreas[0].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            chartPopularity.ChartAreas[0].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);

            chartPopularity.DataSource = loadChart().Tables[0];
            chartPopularity.DataBind();

            int seatTypeCount = loadChart().Tables[0].Rows.Count;
            chartPopularity.ChartAreas[0].AxisX.Interval = Math.Max(1, seatTypeCount / 10);

            chartPopularity.Series["Sold percentage"].XValueMember = "Seat_Type";
            chartPopularity.Series["Sold percentage"].YValueMembers = "Popularity";
            chartPopularity.Series["Sold percentage"].IsValueShownAsLabel = true;

            chartPopularity.Series["Sold percentage"].Font = new Font("Calibri", 10);
            chartPopularity.Series["Sold percentage"].LabelForeColor = Color.Black;

            chartPopularity.Series["Sold percentage"]["PointWidth"] = "0.5";
            chartPopularity.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartPopularity.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartPopularity.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartPopularity.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            dgvPopularityAnalysis.DataSource = loadTable();
            foreach (DataGridViewColumn column in dgvPopularityAnalysis.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dgvPopularityAnalysis.Rows.Count > 0)
            {
                dgvPopularityAnalysis.Height = dgvPopularityAnalysis.ColumnHeadersHeight + (5 * dgvPopularityAnalysis.Rows[0].Height) + 2;
            }
            getStats();
        }

        private DataSet loadChart()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter adapt = new OracleDataAdapter(loadQuery, conn);
            adapt.Fill(ds);
            return ds;
        }

        private DataTable loadTable()
        {
            OracleCommand cmd = new OracleCommand(loadQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            dt.Columns["Seat_Type"].ColumnName = "Seat Type";
            dt.Columns["Bought_Count"].ColumnName = "Bought Seats";
            dt.Columns["Total_Count"].ColumnName = "Total Seats";
            dt.Columns["Popularity"].ColumnName = "Percentage (%)";

            return dt;
        }

        private void getStats()
        {
            string favouriteSeatType = "";
            decimal mostSeatTypeCount = 0;
            string leastFavouriteSeatType = "";
            decimal leastSeatTypeCount = 100;

            foreach (DataRow row in loadChart().Tables[0].Rows)
            {
                decimal soldPercentage = Convert.ToDecimal(row["Popularity"]);
                if (soldPercentage > mostSeatTypeCount)
                {
                    mostSeatTypeCount = soldPercentage;
                    favouriteSeatType = row["Seat_Type"].ToString();
                }
                if (soldPercentage < leastSeatTypeCount)
                {
                    leastSeatTypeCount = soldPercentage;
                    leastFavouriteSeatType = row["Seat_Type"].ToString();
                }
            }
            txtFavSeatType.Text = $"{favouriteSeatType} - {mostSeatTypeCount:0.00}%";
            txtLeastFavSeatType.Text = $"{leastFavouriteSeatType} - {leastSeatTypeCount:0.00}%";
        }

        private int getTotalSeats(string seatType)
        {
            string sqlQuery = $"SELECT COUNT(ms.Seat_Num) FROM Seats s LEFT JOIN MatchSeats ms ON s.Seat_Num = ms.Seat_Num WHERE s.Type_Code = '{seatType}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read() && !dr.IsDBNull(0))
            {
                return dr.GetInt32(0);
            }
            return 0;
        }
    }
}

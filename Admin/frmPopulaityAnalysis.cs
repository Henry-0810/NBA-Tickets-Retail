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
        private string loadQuery = @"SELECT m.Match_ID AS Match_ID, t.Team_Name, COUNT(*) AS Seats_Sold
                                    FROM MatchSeats ms
                                    JOIN Matches m ON ms.Match_ID = m.Match_ID
                                    JOIN Teams t ON m.Team_ID = t.Team_ID
                                    WHERE ms.Status = 'O'
                                    GROUP BY m.Match_ID, t.Team_Name
                                    ORDER BY m.Match_ID";

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
            chartPopularity.ChartAreas[0].AxisX.Title = "Match";
            chartPopularity.ChartAreas[0].AxisY.Title = "Seats Sold";
            chartPopularity.ChartAreas[0].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            chartPopularity.ChartAreas[0].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);

            chartPopularity.DataSource = loadChart().Tables[0];
            chartPopularity.DataBind();

            int matchCount = loadChart().Tables[0].Rows.Count;
            chartPopularity.ChartAreas[0].AxisX.Interval = Math.Max(1, matchCount / 10);

            chartPopularity.Series["Seats Sold"].XValueMember = "Match_ID";
            chartPopularity.Series["Seats Sold"].YValueMembers = "Seats_Sold";
            chartPopularity.Series["Seats Sold"].IsValueShownAsLabel = true;

            chartPopularity.Series["Seats Sold"].Font = new Font("Calibri", 10);
            chartPopularity.Series["Seats Sold"].LabelForeColor = Color.Black;

            chartPopularity.Series["Seats Sold"]["PointWidth"] = "0.5";
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
                dgvPopularityAnalysis.Height = dgvPopularityAnalysis.ColumnHeadersHeight + (10 * dgvPopularityAnalysis.Rows[0].Height) + 2;
            }
            //getStats();
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

            dt.Columns["Match_ID"].ColumnName = "Match ID";
            dt.Columns["Team_Name"].ColumnName = "Team Name";
            dt.Columns["Seats_Sold"].ColumnName = "Total Seats";

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

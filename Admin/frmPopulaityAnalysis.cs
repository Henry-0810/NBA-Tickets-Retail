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
        //Gets the Match_ID, Team_Name and Number of seats sold from database
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

        //Generates a chart and table with information from the query above
        //Get statistics - most popular match, least popular match and average seats sold per match
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
            getStats();
        }

        //This method loads the chart
        private DataSet loadChart()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter adapt = new OracleDataAdapter(loadQuery, conn);
            adapt.Fill(ds);
            return ds;
        }

        //This method loads the table
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

        //This method gets the most popular match, least popular match and average seats sold per match and display them in textboxes
        private void getStats()
        {
            string favouriteMatches = "";
            int mostSeatsSold = 0;
            string leastFavouriteMatches = "";
            int leastSeatsSold = 100;
            int totalSeatsSold = 0;

            foreach (DataRow row in loadChart().Tables[0].Rows)
            {
                int seatsSold = Convert.ToInt32(row["Seats_Sold"]);
                if (seatsSold >= mostSeatsSold)
                {
                    if (seatsSold > mostSeatsSold)
                    {
                        favouriteMatches = "";
                    }
                    mostSeatsSold = seatsSold;
                    favouriteMatches += $" {row["Match_ID"]} - {mostSeatsSold} seats\n";
                }
                if (seatsSold <= leastSeatsSold)
                {
                    if (seatsSold < leastSeatsSold)
                    {
                        leastFavouriteMatches = "";
                    }
                    leastSeatsSold = seatsSold;
                    leastFavouriteMatches += $" {row["Match_ID"]} - {leastSeatsSold} seats\n";
                }
                totalSeatsSold += seatsSold;
            }
            int numOfRows = loadChart().Tables[0].Rows.Count;
            float avgSeatSold = totalSeatsSold / numOfRows;
            txtFavSeatType.Text = favouriteMatches.Trim();
            txtLeastFavSeatType.Text = leastFavouriteMatches.Trim();
            txtAvgSeatsSold.Text = $"{Convert.ToInt32(avgSeatSold)} seats";
        }
    }
}

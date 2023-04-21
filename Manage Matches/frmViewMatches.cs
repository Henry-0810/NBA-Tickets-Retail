using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmViewMatches : Form
    {
        private static new Form Parent;
        public frmViewMatches(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmViewMatches_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void btnVMback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void frmViewMatches_Load(object sender, EventArgs e)
        {
            //Loads match details to data grid view
            OracleConnection conn = Program.getOracleConnection();

            string sqlQeury = "SELECT m.Match_ID, m.Match_Date, m.Match_Time, t.Team_Name FROM Matches m JOIN Teams t ON m.Team_ID = t.Team_ID";

            OracleCommand cmd = new OracleCommand(sqlQeury, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvMatches.Rows.Add(dr.GetString(0), dr.GetOracleDate(1), dr.GetString(2), dr.GetString(3));
            }

            dr.Close();

            //Adjust the height for data grid view
            if (dgvMatches.Rows.Count > 0)
            {
                dgvMatches.Height = dgvMatches.ColumnHeadersHeight + 10 * dgvMatches.Rows[0].Height + 2;
            }
            else
            {
                MessageBox.Show("Team list is blank, add a team!", "Team List Blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

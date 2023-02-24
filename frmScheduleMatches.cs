using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
   
    public partial class frmScheduleMatch : Form
    {
        private Match match;
        private static new Form Parent;
        public frmScheduleMatch(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnSMback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //check all fields entered
            //Match Time
            if(dtPickMatchTime.Value <= DateTime.Now)
            {
                MessageBox.Show("Match Time must be in the future", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtPickMatchTime.Focus();
                return;
            }

            //Away Team
            if(cboAwayTeamID.SelectedIndex == -1)
            {
                MessageBox.Show("Away Team ID is blank!", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cboAwayTeamID.Focus();
                return;
            }

            //save to class
            match = new Match(dtPickMatchTime.Value, cboAwayTeamID.SelectedItem.ToString());
            match.addMatches();
            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Match has Been Created\n" + match.ToString(), "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            dtPickMatchTime.Value = DateTime.Now;
            cboAwayTeamID.SelectedIndex = -1;
            dtPickMatchTime.Focus();
        }

        private void frmScheduleMatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void frmScheduleMatch_Load(object sender, EventArgs e)
        {
            
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT Team_ID FROM Teams";

            OracleCommand cmd = new OracleCommand(sqlQuery,conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    string team_ID = dr.GetString(0);
                    cboAwayTeamID.Items.Add(team_ID);
                }
            }

            dr.Close();
        }

   
    }

}

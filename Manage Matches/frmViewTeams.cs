using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmViewTeams : Form
    {
        private static List<AwayTeam> allTeams;
        private static new Form Parent;
        public frmViewTeams(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void FrmViewTeams_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void FrmViewTeams_Load(object sender, System.EventArgs e)
        {
            AwayTeam.viewAllTeams(ref allTeams);
            foreach(AwayTeam team in allTeams)
            {
                dgvTeamList.Rows.Add(team.AwayTeamID, team.TeamName);
            }
            if (dgvTeamList.Rows.Count > 0)
            {
                int headerHeight = dgvTeamList.ColumnHeadersHeight;
                int rowsHeight = 10 * dgvTeamList.Rows[0].Height;

                dgvTeamList.Height = headerHeight + rowsHeight + 2;
                dgvTeamList.Width = 210;
            }
            else
            {
                MessageBox.Show("Team list is blank, add a team!", "Team List Blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVTback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
    }
}

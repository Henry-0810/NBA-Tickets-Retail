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

           
            
        }
    }
}

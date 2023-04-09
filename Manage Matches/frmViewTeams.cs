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
            int count = 0;
            AwayTeam.viewAllTeams(ref allTeams);
            foreach(AwayTeam team in allTeams)
            {
                dgvTeamList.Rows.Add(team.AwayTeamID, team.TeamName);
                count++;
            }
            Console.WriteLine(dgvTeamList.Width);
            Console.WriteLine(dgvTeamList.Height);
            Console.WriteLine(dgvTeamList.Rows[0].Height);
            Console.WriteLine(count);
           

            // Calculate the total height of the header and data rows
            int headerHeight = dgvTeamList.ColumnHeadersHeight;
            int rowsHeight = count * dgvTeamList.Rows[0].Height;

            // Set the height of the DataGridView to fit the header and data rows
            dgvTeamList.Height = headerHeight + rowsHeight + 2;
            dgvTeamList.Width = 210;


        }

        private void btnVTback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
    }
}

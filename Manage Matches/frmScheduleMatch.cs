using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
   
    public partial class frmScheduleMatch : Form
    {
        private Match match;
        private static new Form Parent;
        private static List<Team> allTeams;
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
            //validation
            if(dtPickMatchTime.Value <= DateTime.Now)
            {
                MessageBox.Show("Match Date must be in the future", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtPickMatchTime.Focus();
                return;
            }

            DateTime parsedTime;
            if (!DateTime.TryParseExact(txtMatchTime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedTime))
            {
                MessageBox.Show("Invalid time format. Please enter a valid time in the format 'HH:mm'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboAwayTeam.SelectedIndex == -1)
            {
                MessageBox.Show("Away Team ID is blank!", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cboAwayTeam.Focus();
                return;
            }

            //Save to class
            match = new Match(dtPickMatchTime.Value.ToString("yyyy-MMM-dd").Substring(0, 11), txtMatchTime.Text.ToString() ,cboAwayTeam.SelectedItem.ToString().Substring(0,3));
            //Save to database
            match.addMatch();

            //Display confirmation message
            MessageBox.Show($"Match has Been Created\n{match}\nAway Team: {cboAwayTeam.SelectedItem.ToString().Substring(6)}", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            dtPickMatchTime.Value = DateTime.Now;
            txtMatchTime.Clear();
            cboAwayTeam.SelectedIndex = -1;
            dtPickMatchTime.Focus();
        }

        private void frmScheduleMatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void frmScheduleMatch_Load(object sender, EventArgs e)
        {
            //Set date time picker to now and format to 'yyyy-MM-dd'
            dtPickMatchTime.Value = DateTime.Now;
            dtPickMatchTime.Format = DateTimePickerFormat.Custom;
            dtPickMatchTime.CustomFormat = "yyyy-MM-dd";
            //Loads teams into combobox
            Team.viewAllTeams(ref allTeams);
            foreach(Team team in allTeams)
            {
                cboAwayTeam.Items.Add(team.ToString());
            }
        }

        private void btnViewMatches_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewMatches frmViewMatches = new frmViewMatches(this);
            frmViewMatches.Show();
        }
    }

}

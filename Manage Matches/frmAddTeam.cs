﻿
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    
    public partial class frmAddTeam : Form
    {
        Team teams;
        private static new Form Parent;
        public frmAddTeam(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnATback_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void btnViewTeams_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frmViewTeams frmViewTeams = new frmViewTeams(this);
            frmViewTeams.Show();
        }

        private void frmAddTeams_FormClosed(object sender, FormClosedEventArgs e)
        { 
            Parent.Visible = true;
        }

        private void btnAddTeams_Click(object sender, System.EventArgs e)
        {
            TextBox[] textBoxes = { txtTeamID, txtTeamName };
            Label[] labels = { lblTeamID, lblTeamName };
            //Validation
            for(int j = 0; j < textBoxes.Length; j++)
            {
                string txt = labels[j].Text.ToString().Remove(labels[j].Text.Length - 2);
                if(textBoxes[j].Text == null || textBoxes[j].Text.Equals(""))
                {
                    MessageBox.Show(txt + " is blank!!!", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    textBoxes[j].Focus();
                    return;
                }
                for (int i = 0; i < textBoxes[j].Text.Length; i++)
                {
                    if (char.IsDigit(textBoxes[j].Text[i]))
                    {
                        MessageBox.Show(txt + " can only contain letters!!!", "Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        textBoxes[j].Focus();
                        return;
                    }
                }
            }
            //Save to class
            teams = new Team(txtTeamID.Text.ToString(), txtTeamName.Text.ToString());
            //Save to database
            teams.addTeam();
            //Confirmation message 
            MessageBox.Show("Team: " + teams.TeamName + " added to database","Successfully added", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            txtTeamID.Text = "";
            txtTeamName.Text = "";
            txtTeamID.Focus();
        }
    }
}


using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmAddTeams : Form
    {
        private static new Form Parent;
        public frmAddTeams(Form parent)
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
            //validation
            if (txtTeamID.Text == null || txtTeamID.Text.Equals(""))
            {
                MessageBox.Show("Team ID is blank!!!", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTeamID.Focus();
                return;
            }
            for(int j = 0; j < textBoxes.Length; j++)
            {
                for (int i = 0; i < textBoxes[j].Text.Length; i++)
                {
                    if (char.IsDigit(textBoxes[j].Text[i]))
                    {
                        string txt = labels[j].Text.ToString().Remove(labels[j].Text.Length-2);
                        MessageBox.Show(txt + " can only contain letters!!!", "Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        textBoxes[j].Focus();
                        return;
                    }
                }
            }
            
       
        }
    }
}

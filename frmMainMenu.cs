using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            
        }

        private void addSeatTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddSeatType frmAddSeatType = new frmAddSeatType(this);
            frmAddSeatType.Show();
        }


        private void updateSeatTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SeatType.getSeatTypesCount() == 0)
            {
                MessageBox.Show("No Seat Type, must assign seat type before updating one!", "Seat Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmUpdateSeatType frmUpdateSeatType = new frmUpdateSeatType(this);
                frmUpdateSeatType.Show();
                Visible = false;
            }
                
        }

        private void addTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddTeams frmAddTeams = new frmAddTeams(this);
            frmAddTeams.Show();
        }

        private void scheduleMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SeatType.getSeatTypesCount() == 0)
            {
                MessageBox.Show("No Seat Type, must assign seat type before scheduling a match!", "Seat Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(Team.getTeamsCount() == 0)
                {
                    MessageBox.Show("No Team, must assign team before scheduling a match!", "Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.Hide();
                    frmScheduleMatch frmScheduleMatch = new frmScheduleMatch(this);
                    frmScheduleMatch.Show();
                }
            }
        }


        private void processSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SeatType.getSeatTypesCount() == 0)
            {
                MessageBox.Show("No Seat Type, must assign a seat type before processing a sale!", "Seat Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Team.getTeamsCount() == 0)
                {
                    MessageBox.Show("No Team, must assign a team before processing a sale!", "Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Match.getMatchesCount() == 0)
                    {
                        MessageBox.Show("No Match, must assign a match before processing a sale!", "Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.Hide();
                        frmProcessSales frmProcessSales = new frmProcessSales(this);
                        frmProcessSales.Show();
                    }
                }
            }
        }

        private void returnSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Sale.isSalesEmpty() == 0){
                MessageBox.Show("No Sale, must assign a sale before returning a sale!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;          
            }
            else
            {
                this.Hide();
                frmReturnSale frmReturnSale = new frmReturnSale(this);
                frmReturnSale.Show();
            }
        }


        private void RunAnalysis(string analysisName, Form form)
        {
            if (SeatType.getSeatTypesCount() == 0)
            {
                MessageBox.Show($"No Seat Type, must assign a seat type before running a {analysisName} Analysis!", "Seat Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Team.getTeamsCount() == 0)
            {
                MessageBox.Show($"No Team, must assign a team before running a {analysisName} Analysis!", "Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Match.getMatchesCount() == 0)
            {
                MessageBox.Show($"No Match, must assign a match before running a {analysisName} Analysis!", "Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Sale.isSalesEmpty() == 0)
            {
                MessageBox.Show($"No Sale, must assign a sale before running a {analysisName} Analysis!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            form.ShowDialog();
        }

        private void seasonalSalesAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunAnalysis("Seasonal Sales", new frmSeasonalSalesAnalysis(this));
        }

        private void popularityAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunAnalysis("Popularity", new frmPopulaityAnalysis(this));
        }

    }
}

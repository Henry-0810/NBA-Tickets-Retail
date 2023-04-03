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
            if (SeatType.isSeatTypesEmpty() == 0)
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


        private void scheduleMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SeatType.isSeatTypesEmpty() == 0)
            {
                MessageBox.Show("No Seat Type, must assign seat type before scheduling a match!", "Seat Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(AwayTeam.isTeamsEmpty() == 0)
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


        private void processSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SeatType.isSeatTypesEmpty() == 0)
            {
                MessageBox.Show("No Seat Type, must assign a seat type before processing a sale!", "Seat Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (AwayTeam.isTeamsEmpty() == 0)
                {
                    MessageBox.Show("No Team, must assign a team before processing a sale!", "Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Match.isMatchesEmpty() == 0)
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

        private void returnTicketsToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SeatType.isSeatTypesEmpty() == 0)
            {
                MessageBox.Show("No Seat Type, must assign a seat type before running a seasonal sales analysis!", "Seat Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (AwayTeam.isTeamsEmpty() == 0)
                {
                    MessageBox.Show("No Team, must assign a team before running a seasonal sales analysis!", "Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Match.isMatchesEmpty() == 0)
                    {
                        MessageBox.Show("No Match, must assign a match before running a seasonal sales analysis!", "Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.Hide();
                        frmSeasonalSalesAnalysis frmSeasonalAnalysis = new frmSeasonalSalesAnalysis(this);
                        frmSeasonalAnalysis.Show();
                    }
                }
            }
        }

        private void seatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SeatType.isSeatTypesEmpty() == 0)
            {
                MessageBox.Show("No Seat Type, must assign a seat type before running a popularity analysis!", "Seat Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (AwayTeam.isTeamsEmpty() == 0)
                {
                    MessageBox.Show("No Team, must assign a team before running a popularity analysis!", "Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Match.isMatchesEmpty() == 0)
                    {
                        MessageBox.Show("No Match, must assign a match before running a popularity analysis!", "Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        this.Hide();
                        frmPopulaityAnalysis frmPopulaityAnalysis = new frmPopulaityAnalysis(this);
                        frmPopulaityAnalysis.Show();
                    }
                }
            }
        }
        

        private void addTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddTeams frmAddTeams = new frmAddTeams(this);
            frmAddTeams.Show();
        }
    }
}

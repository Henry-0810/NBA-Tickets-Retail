using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            frmUpdateSeatType frmUpdateSeatType = new frmUpdateSeatType(this);
            frmUpdateSeatType.Show();
            Visible = false;
        }


        private void scheduleMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScheduleMatch frmScheduleMatch = new frmScheduleMatch(this);
            frmScheduleMatch.Show(); 
        }


        private void processSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProcessSales frmProcessSales = new frmProcessSales(this);
            frmProcessSales.Show();
        }

        private void returnTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnSale frmReturnSale = new frmReturnSale(this);
            frmReturnSale.Show();
        }


        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeasonalSalesAnalysis frmSeasonalAnalysis = new frmSeasonalSalesAnalysis(this);
            frmSeasonalAnalysis.Show();
        }

        private void seatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPopulaityAnalysis frmPopulaityAnalysis = new frmPopulaityAnalysis(this);
            frmPopulaityAnalysis.Show();
        }
    }
}

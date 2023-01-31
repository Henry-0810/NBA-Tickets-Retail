using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmSeasonalSalesAnalysis : Form
    {
        private static new Form Parent;
        public frmSeasonalSalesAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnYRAback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }


        
        private void frmYearlyRevenueAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void btnMaxSales_Click(object sender, EventArgs e)
        {
            //calculations for most sales
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Most sales per match is calculated: \nit is 'algorithm next semester'", 
                "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnMinSales_Click(object sender, EventArgs e)
        {
            //calculations for least sales
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Least sales per match is calculated: \nit is 'algorithm next semester'",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSeasonRevenue_Click(object sender, EventArgs e)
        {
            //calculations for total sales overall per season
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Total sales for this season is calculated: \nit is 'algorithm next semester'",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAvgSales_Click(object sender, EventArgs e)
        {
            //calculations for average sales
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Average sales per match is calculated: \nit is 'algorithm next semester'",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            //show a graph for sales per match
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Graph succesfully plotted: 'algorithm next semester'",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

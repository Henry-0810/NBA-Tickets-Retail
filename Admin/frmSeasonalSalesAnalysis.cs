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

        private void frmSeasonalSalesAnalysis_Load(object sender, EventArgs e)
        {

        }
    }
}

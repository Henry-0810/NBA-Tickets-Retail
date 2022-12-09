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
    public partial class frmPopulaityAnalysis : Form
    {
        private static new Form Parent;
        public frmPopulaityAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnSAback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void frmSeatsSoldperMatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void btnMaxSeats_Click(object sender, EventArgs e)
        {
            //calculations for most seats sold
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Most seats sold per match is calculated: \nit is 'algorithm next semester'",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMinSales_Click(object sender, EventArgs e)
        {
            //calculations for least seats sold
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Least seats sold per match is calculated: \nit is 'algorithm next semester'",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAvgSeats_Click(object sender, EventArgs e)
        {
            //calculations for average seats sold
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Average seats sold per match is calculated: \nit is 'algorithm next semester'",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            //show a graph for seats sold per match
            //will be done next semester
            //no validation needed because all Manager did not enter information
            MessageBox.Show("Graph succesfully plotted: 'algorithm next semester'",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

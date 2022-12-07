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
    public partial class frmYearlyRevenueAnalysis : Form
    {
        private static new Form Parent;
        public frmYearlyRevenueAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnYRAback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            cboMatchID.Items.Add(1);
            cboMatchID.Items.Add(2);
            cboMatchID.Items.Add(3);
        }

        private void btnCalcTotSales_Click(object sender, EventArgs e)
        {
            if (cboMatchID.SelectedIndex == -1)
            {
                MessageBox.Show("Match ID is blank", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                cboMatchID.Focus();
                return;
            }
            
            //Calculates total sales from selected match ID
            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Total sales for this match is calculated", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            txtSales.Text = "Hardcode";
            grpSales.Visible = true;

        }

        private void btnTotRev_Click(object sender, EventArgs e)
        {
            if (cboMatchID.SelectedIndex == -1)
            {
                MessageBox.Show("Match ID is blank", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                cboMatchID.Focus();
                return;
            }
            //get all matches' sales and show total amount of money the stadium make per season
            //message box as validation
            if(grpSales.Visible == false)
            {
                MessageBox.Show("Sales not calculated!", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Total revenue is *Total amount of money*", "Information", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            
           
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            if (cboMatchID.SelectedIndex == -1)
            {
                MessageBox.Show("Match ID is blank", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                cboMatchID.Focus();
                return;
            }
            //plot a graph for revenue
            //message box as validation
            if(grpSales.Visible == false)
            {
                MessageBox.Show("Sales not calculated!", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Graph is plotted", "Information", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            
           
        }

        private void frmYearlyRevenueAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }
    }
}

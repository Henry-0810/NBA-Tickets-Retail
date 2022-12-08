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

        private void btnMostSeatsSold_Click(object sender, EventArgs e)
        {
            if (cboMatchID.SelectedIndex == -1)
            {
                MessageBox.Show("Match ID is blank", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                cboMatchID.Focus();
                return;
            }
            //show which match has most seats sold
            if(grpSeats.Visible == false)
            {
                MessageBox.Show("Seats sold not calculated", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Total seats sold is *number of seats sold*", "Information", MessageBoxButtons.OK,
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
            //plot a graph for seats sold
            if (grpSeats.Visible == false)
            {
                MessageBox.Show("Seats sold not calculated", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Graph is plotted", "Information", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            
          
        }

        private void frmSeatsSoldperMatch_Load(object sender, EventArgs e)
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
            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Seats sold for this match is calculated", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            txtSeats.Text = "Hardcode";
            grpSeats.Visible = true;
        }

        private void frmSeatsSoldperMatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

       
    }
}

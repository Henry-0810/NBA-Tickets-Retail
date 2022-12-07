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
    public partial class frmCheckAvailability : Form
    {
        private static new Form Parent;
        public frmCheckAvailability(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnCAback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void frmCheckAvailability_Load(object sender, EventArgs e)
        {   //hard code for validation
            cboMatchID.Items.Add(1);
            cboMatchID.Items.Add(2);
            cboMatchID.Items.Add(3);
        }

        private void cboMatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpProcessSales.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //validation    
            if (numSeatFrom.Value > numSeatTo.Value)
            {
                MessageBox.Show("Seat To must be greater than Seat From", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                numSeatFrom.Focus();
                return;
            }

            //get status from salesticket file
            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Seats are " + "*getting the status from salesticket file*", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            cboMatchID.SelectedIndex = -1;
            numSeatTo.Value = 1;
            numSeatFrom.Value = 1;
            grpProcessSales.Visible = false;
            cboMatchID.Focus();
        }

        private void frmCheckAvailability_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }
    }
}

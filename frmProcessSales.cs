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
    public partial class frmProcessSales : Form
    {
        private static new Form Parent;
        public frmProcessSales(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }


        private void btnPSback_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //validation    
            if(numSeatFrom.Value > numSeatTo.Value)
            {
                MessageBox.Show("Seat To must be greater than Seat From", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                numSeatFrom.Focus();
                return;
            }

            if(cboStatusPS.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an option for Status", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatusPS.Focus();
                return;
            }

            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Sales processed", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            cboMatchID.SelectedIndex = -1;
            numSeatTo.Value = 1;
            numSeatFrom.Value = 1;
            cboStatusPS.SelectedIndex = -1;
            grpProcessSales.Visible = false;
            cboMatchID.Focus();
        }

        private void frmProcessSales_Load(object sender, EventArgs e)
        {
            cboMatchID.Items.Add(1);
            cboMatchID.Items.Add(2);
            cboStatusPS.Items.Add("U");
            cboStatusPS.Items.Add("O");
        }

        private void cboMatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpProcessSales.Visible = true;
        }

        private void frmProcessSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }
    }
}

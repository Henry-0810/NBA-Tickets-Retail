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
    public partial class frmReturnTickets : Form
    {
        private static new Form Parent;
        public frmReturnTickets(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnRTback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //SeatFrom and SeatTo number get from SalesTicket file
            //validation    
            if (cboStatusRT.SelectedIndex == 1)
            {
                MessageBox.Show("Status must be 'U'!", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cboStatusRT.Focus();
                return;
            }

            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Tickets returned", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            getSeatFrom.Text = "";
            getSeatTo.Text = "";
            cboStatusRT.SelectedIndex = -1;
            cboSTID.SelectedIndex = -1; 
            grpReturn.Visible = false;
            cboSTID.Focus();
        }

        private void cboSTID_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpReturn.Visible = true;
        }

        private void frmReturnTickets_Load(object sender, EventArgs e)
        {
            cboSTID.Items.Add("1");
            cboSTID.Items.Add("2");
            cboSTID.Items.Add("3");
            cboStatusRT.Items.Add("U");
            cboStatusRT.Items.Add("O");
        }
    }
}

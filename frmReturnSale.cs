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
    public partial class frmReturnSale : Form
    {
        private static new Form Parent;
        public frmReturnSale(Form parent)
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
           
            //validation    
            
            

            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Sales returned", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            
            cboSTID.SelectedIndex = -1;
            TextBox[] textBoxes = { txtMatchID, txtSeat1, txtSeat2, txtSeat3, txtSeat4, txtTotSales };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Enabled = false;
            }
            dtPickSalesDate.Enabled = false;
            btnReturn.Enabled = false;
            cboSTID.Focus();
        }

        private void cboSTID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validation
            //all txtboxes are accessible only if saleID is picked
            TextBox[] textBoxes = { txtMatchID, txtSeat1, txtSeat2, txtSeat3, txtSeat4, txtTotSales };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Enabled = true;
            }
            dtPickSalesDate.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void frmReturnTickets_Load(object sender, EventArgs e)
        {
            cboSTID.Items.Add("1");
            cboSTID.Items.Add("2");
            cboSTID.Items.Add("3");
            
        }

        private void frmReturnTickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void txtSeat1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeat2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatchID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

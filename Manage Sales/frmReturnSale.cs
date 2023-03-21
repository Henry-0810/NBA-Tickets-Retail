using System;
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
            txtMatchID.Text = "";
            txtSeat1.Text = "";
            txtSeat2.Text = "";
            txtSeat3.Text = "";
            txtSeat4.Text = "";
            dtPickSalesDate.Value = DateTime.Now;
            txtTotSales.Text = "";
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
            txtMatchID.Text = "1";
            txtSeat1.Text = "1";
            txtSeat2.Text = "2";
            txtSeat3.Text = "3";
            txtSeat4.Text = "4";
            dtPickSalesDate.Value = DateTime.Now;
            txtTotSales.Text = "100.00";
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

        
    }
}

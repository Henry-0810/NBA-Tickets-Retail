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
    public partial class frmAddSeatType : Form
    {
        public frmAddSeatType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {   
            //check all fields entered
            //type code
            if(txtTypeCode.Text.Equals(""))
            {
                MessageBox.Show("Type Code must be Entered", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTypeCode.Focus();
                return;
            }

            //description
            if(txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be Entered", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            //price
            if(Convert.ToDouble(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Price must be more than 0", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            //Seat to
            if(Convert.ToInt32(txtSeatTo.Text) < 0 && Convert.ToInt32(txtSeatTo.Text) > 500)
            {
                MessageBox.Show("Seat To must be Entered within given range", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeatTo.Focus();
                return;
            }

            //SeatFrom
            if(Convert.ToInt32(txtSeatFrom.Text) < 0 && Convert.ToInt32(txtSeatFrom.Text) > 500)
            {
                MessageBox.Show("Seat From must be Entered within given range", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeatFrom.Focus();
                return;
            }

            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Seat Type has Been Created", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            txtTypeCode.Clear();
            txtDescription.Clear(); 
            txtPrice.Text = "0.00";
            txtSeatTo.Clear();
            txtSeatFrom.Clear();
            txtTypeCode.Focus();
        }

        private void btnASTback_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();    
            frmMainMenu.Show();
            Visible = false;
        }
    }
}
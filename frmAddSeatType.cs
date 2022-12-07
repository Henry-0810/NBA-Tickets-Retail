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
        private static new Form Parent;
        public frmAddSeatType(Form parent)
        {
            InitializeComponent();
            Parent = parent;
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

            //SeatFrom
            if (txtSeatFrom.Text.Equals(""))
            {
                MessageBox.Show("Seat From is blank", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeatFrom.Focus();
                return;
            }
            else if (Convert.ToInt32(txtSeatFrom.Text) <= 0 || Convert.ToInt32(txtSeatFrom.Text) > 500)
            {
                MessageBox.Show("Seat From must be Entered within given range", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeatFrom.Focus();
                return;
            }

            //Seat to
            if (txtSeatTo.Text.Equals(""))
            {
                MessageBox.Show("Seat To is blank", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeatTo.Focus();
                return;
            }
            else if(Convert.ToInt32(txtSeatTo.Text) <= 0 || Convert.ToInt32(txtSeatTo.Text) > 500)
            {
                MessageBox.Show("Seat To must be Entered within given range", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeatTo.Focus();
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

        private void btnASTback_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void frmAddSeatType_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }
    }
}
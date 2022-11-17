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
    public partial class frmUpdateSeatType : Form
    {
        private static new Form Parent;
        public frmUpdateSeatType(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        

        private void frmUpdateSeatType_Load(object sender, EventArgs e)
        {
            //Load Seat types
            cboSeatTypes.Items.Add("FR - Front Row");
            cboSeatTypes.Items.Add("BR - Back Row");
        }

        private void btnUSTback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }



        private void cboSeatTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescription.Text = "Front Row block 1";
            txtPrice.Text = "85.00";
            grpType.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check validation
            if (Convert.ToDouble(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Price must be more than 0", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
        }

    }
}

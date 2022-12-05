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
    public partial class frmManageSales : Form
    {
        private static new Form Parent;
        public frmManageSales(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmManageSales_Load(object sender, EventArgs e)
        {
            //Load Seat types
            cboManageSales.Items.Add("FR - Front Row");
            cboManageSales.Items.Add("BR - Back Row");
        }

        private void cboManageSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpSales.Visible = true;
        }

        private void btnMSback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txtSales.Text) <= 0)
            {
                MessageBox.Show("Sales must be more than 0", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSales.Focus();
                return;
            }

            if (dtPickSalesDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Sales date must be in the future", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtPickSalesDate.Focus();
                return;
            }

            if (Convert.ToInt32(txtSeatSold.Text) <= 0)
            {
                MessageBox.Show("Seat sold be more than 0", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSeatSold.Focus();
                return;
            }

            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Sales has Been Added", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            cboManageSales.SelectedIndex = -1;
            txtSales.Text = "0.00";
            dtPickSalesDate.Value = DateTime.Now;
            txtSeatSold.Clear();
            grpSales.Visible = false;
            cboManageSales.Focus();
        }

      
    }
}

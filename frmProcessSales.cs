using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            

            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Sales processed", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            cboMatchID.SelectedIndex = -1;
            
            
            cboMatchID.Focus();
        }

        private void frmProcessSales_Load(object sender, EventArgs e)
        {
            cboMatchID.Items.Add(1);
            cboMatchID.Items.Add(2);
            cboNumSeats.Items.AddRange(new object[] { 1, 2, 3, 4 });
        }

        private void cboMatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNumSeats.Enabled = true;
        }

        private void frmProcessSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void cboNumSeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtSeat1, txtSeat2, txtSeat3, txtSeat4 };
            int idx = cboNumSeats.SelectedIndex + 1;
            foreach (TextBox text in textBoxes)
            {
                text.Enabled = false;
            }
            btnProcess.Enabled = true;
            for(int i = 0; i < idx; i++)
            {
                textBoxes[i].Enabled = true;
            }
        }
    }
}

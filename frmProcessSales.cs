using System;
using System.Collections.Generic;

using System.Linq;

using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmProcessSales : Form
    {
        private static new Form Parent;
        Sales sale;
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
            TextBox[] textBoxes = { txtSeat1, txtSeat2, txtSeat3, txtSeat4 };
            for (int i = 0; i < cboNumSeats.SelectedIndex + 1; i++)
            { 
                string txtBox = textBoxes[i].Text;
                //check null
                if (txtBox.Equals(""))
                {
                    MessageBox.Show("All fields are required to enter!!", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    textBoxes[i].Focus();
                    return;
                }
                int isInt;
                bool valid = int.TryParse(txtBox, out isInt);
                //check isDigit
                if (!valid)
                {
                    MessageBox.Show("Seat Number must be an integer", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    textBoxes[i].Focus();
                    return;
                }
                //check in range of 1-500
                else if (Convert.ToInt32(txtBox) <= 0 || Convert.ToInt32(txtBox) > 500) 
                {
                    MessageBox.Show("Seat Number must be in range of 1-500", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    textBoxes[i].Focus();
                    return;
                }

                List<int> Seats = new List<int> { };
                for(int j = i; j >= 0; j--)
                {
                    Seats.Add(Convert.ToInt32(textBoxes[j].Text));
                }
                //check all seat number entered is distinct
                if(new HashSet<int>(Seats).Count() != Seats.Count)
                {
                    MessageBox.Show("Seat Numbers entered cannot be the same", "Error!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    textBoxes[i].Focus();
                    return;
                }

            }
            //save to class
            //sale = new Sales(Convert.ToInt32(txtSeat1.Text), Convert.ToInt32(txtSeat2.Text),
                //Convert.ToInt32(txtSeat3.Text), Convert.ToInt32(txtSeat4.Text), 1);
            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Sales processed", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            cboMatchID.SelectedIndex = -1;
            cboNumSeats.SelectedIndex = -1;
            cboNumSeats.Enabled = false;
            foreach (TextBox text in textBoxes)
            {
                text.Clear();
                text.Enabled = false;
            }
            btnProcess.Enabled = false;
            cboMatchID.Focus();
        }

        private void frmProcessSales_Load(object sender, EventArgs e)
        {
            cboMatchID.Items.Add(1);
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

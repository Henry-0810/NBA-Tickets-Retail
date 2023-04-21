using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmProcessSale : Form
    {
        private static double totPrice = 0;
        private static List<string> allMatchID;
        private static List<string> allSeatTypes;
        private static string[] cboSeatTypeItems;
        private static new Form Parent;
        public frmProcessSale(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }


        private void btnPSback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void FrmProcessSales_Load(object sender, EventArgs e)
        {
            //Load Match details into combobox
            Match.showMatchDetails(ref allMatchID);
            foreach (string matchID in allMatchID)
            {
                cboMatches.Items.Add(matchID);
            }
        }

        private void CboMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSeatType.Items.Clear();
            cboSeatType.Enabled = true;
            //Loads seat types that are still available for the selected match into combobox
            SeatType.getSeatTypeDetails(ref allSeatTypes);
            if(cboMatches.SelectedIndex != -1)
            {
                foreach (string seatType in allSeatTypes)
                {
                    if (Seat.getTotalNumSeatsLeft(seatType.Substring(0, 3), cboMatches.SelectedItem.ToString().Substring(0, 3)) > 0)
                    {
                        cboSeatType.Items.Add(seatType);
                        cboSeatTypeItems = cboSeatType.Items.Cast<string>().ToArray();
                    }
                }
            }
        }

        private void FrmProcessSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void CboSeatTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSeatType.SelectedIndex != -1)
            {
                numberOfSeats.Enabled = true;
                numberOfSeats.Value = 1;
                //Gets the total number of seats left for that seat type from the match, if less than 4, then maximum of number of seats will be the number of seats left
                int seatsLeft = Seat.getTotalNumSeatsLeft(cboSeatType.SelectedItem.ToString().Substring(0,3), 
                    cboMatches.SelectedItem.ToString().Substring(0,3));
                numberOfSeats.Maximum = Math.Min(seatsLeft, 4);
                btnProcess.Enabled = true;
                lblSeatType.Text = $"Seat Type - {cboSeatType.SelectedItem.ToString().Substring(0,3)}";
            }
        }
           
        //Validate email format
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //When click cancel, it removes the row and adds the seat type option back to the combobox, total price would change
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCart.RowCount == 1)
            {
                btnCheckOut.Enabled = false;
                cboMatches.Enabled = true;
            }

            if (e.ColumnIndex == dgvCart.Columns["Cancellation"].Index && e.RowIndex >= 0)
            {
                if (dgvCart.RowCount == 1)
                {
                    dgvCart.Height = dgvCart.ColumnHeadersHeight;
                }
                else
                {
                    dgvCart.Height = dgvCart.ColumnHeadersHeight + dgvCart.Rows.Count * dgvCart.Rows[e.RowIndex].Height + 2;
                }
                totPrice -= Convert.ToDouble(dgvCart.Rows[e.RowIndex].Cells[2].Value);
                txtTotPrice.Text = totPrice.ToString("0.00");
                for(int i = 0; i < cboSeatTypeItems.Length; i++)
                {
                    if (cboSeatTypeItems[i].Contains(dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        cboSeatType.Items.Add(cboSeatTypeItems[i]);
                    }
                }
                dgvCart.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validation
            TextBox[] optionalBoxes = { txtName, txtEmail };
            for (int i = 0; i < optionalBoxes.Length; i++)
            {
                if (String.IsNullOrEmpty(optionalBoxes[i].Text))
                {
                    optionalBoxes[0].Text = "Guest";
                    optionalBoxes[1].Text = "-";
                }
                else
                {
                    if (!Regex.IsMatch(optionalBoxes[0].Text.ToString(), "^[a-zA-Z]"))
                    {
                        MessageBox.Show("Incorrect name format!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        optionalBoxes[0].Focus();
                        return;
                    }
                    else
                    {
                        if (optionalBoxes[1].Text.Equals("-") || String.IsNullOrEmpty(optionalBoxes[1].Text))
                        {
                            continue;
                        }
                        if (!IsValid(optionalBoxes[1].Text.ToString()))
                        {
                            MessageBox.Show("Incorrect email format!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            optionalBoxes[1].Focus();
                            return;
                        }
                    }
                }
            }
            //Assigns the seat number
            int assignedSeat = Seat.getLatestUnoccupiedSeatNum(cboSeatType.SelectedItem.ToString().Substring(0, 3),
                cboMatches.SelectedItem.ToString().Substring(0, 3));
            string pickedSeats = $"{assignedSeat}";
            double itemPrice = SeatType.getPrice(cboSeatType.SelectedItem.ToString().Substring(0, 3)) * Convert.ToDouble(numberOfSeats.Value);
            for (int i = 1; i <= numberOfSeats.Value - 1; i++)
            {
                pickedSeats += $", {assignedSeat + i}";
            }
            //Add details to the cart
            dgvCart.Rows.Add(cboSeatType.SelectedItem.ToString().Substring(0, 3), pickedSeats, itemPrice);
            //Adds the price to total price
            totPrice += itemPrice;
            txtTotPrice.Text = totPrice.ToString("0.00");
            //Reset UI
            cboMatches.Enabled = false;
            numberOfSeats.Value = 1;
            btnProcess.Enabled = false;
            cboSeatType.Items.Remove(cboSeatType.SelectedItem);
            cboSeatType.SelectedIndex = -1;
            cboSeatType.Focus();
            grpBoxCart.Visible = true;
            btnCheckOut.Enabled = true;
            lblSeatType.Text = "Seat Type";
            // Calculate the total height of the header and data rows
            dgvCart.Height = dgvCart.ColumnHeadersHeight + dgvCart.Rows.Count * dgvCart.Rows[0].Height + 2;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //Save to class
            Sale sale = new Sale(txtName.Text.ToString(), txtEmail.Text.ToString(), DateTime.Now, Convert.ToDouble(txtTotPrice.Text), 
                cboMatches.SelectedItem.ToString().Substring(0, 3));
            //Save to database
            sale.addSale();
            foreach(DataGridViewRow row in dgvCart.Rows)
            {
                string[] seatNums = row.Cells["seatNum"].Value.ToString().Split(',');
                int[] seatNumArr = Array.ConvertAll(seatNums, s => int.Parse(s));
                for(int i = 0; i < seatNumArr.Length; i++)
                {
                    //Create sale seat objects and saves to database
                    SaleSeat saleSeat = new SaleSeat(sale.SalesID, seatNumArr[i]);
                    saleSeat.addSaleSeat();
                    //Update status for matchSeats to 'O' as its occupied
                    MatchSeat.updateSeatStatus(sale.MatchID,seatNumArr[i]);
                }
            }

            //Confirmation message
            MessageBox.Show("Succesfully purcahse seats", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //reset UI
            txtName.Clear();
            txtEmail.Clear();
            cboMatches.SelectedIndex = -1;
            cboMatches.Enabled = true;
            cboSeatType.SelectedIndex = -1;
            cboSeatType.Enabled = false;
            cboSeatType.Items.Clear();
            numberOfSeats.Value = 1;
            numberOfSeats.Enabled = false;
            dgvCart.Rows.Clear();
            dgvCart.Height = dgvCart.ColumnHeadersHeight;
            dgvCart.Refresh();
            totPrice = 0;
            txtTotPrice.Text = $"{totPrice}";
            grpBoxCart.Visible = false;
            btnProcess.Enabled = false;
            btnCheckOut.Enabled = false;
            lblSeatType.Text = "Seat Type";
        }
    }
}
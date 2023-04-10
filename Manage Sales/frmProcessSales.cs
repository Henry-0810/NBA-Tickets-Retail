using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmProcessSales : Form
    {
        private static int count = 0;
        private static double totPrice = 0;
        private static List<string> allMatchID;
        private static List<string> allSeatTypes;
        private static string[] cboSeatTypeItems;
        private static new Form Parent;
        private Sale sale;
        private List<int> seatNums = new List<int>();
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
            TextBox[] optionalBoxes = { txtName, txtEmail };
            for (int i = 0; i < optionalBoxes.Length; i++)
            {
                if(String.IsNullOrEmpty(optionalBoxes[i].Text))
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
                        if (optionalBoxes[1].Text.Equals("-"))
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
            int assignedSeat = Seat.GetLatestUnoccupiedSeatNum(cboSeatType.SelectedItem.ToString().Substring(0, 3), 
                cboMatches.SelectedItem.ToString().Substring(0, 2));
            string pickedSeats = $"{assignedSeat}";
            double itemPrice = SeatType.getPrice(cboSeatType.SelectedItem.ToString().Substring(0, 3)) * Convert.ToDouble(numberOfSeats.Value);
            for (int i = 1; i <= numberOfSeats.Value-1; i++)
            {
                pickedSeats += $", {assignedSeat + i}";
            }
            dgvCart.Rows.Add(cboSeatType.SelectedItem.ToString().Substring(0,3), pickedSeats, itemPrice);
            totPrice += itemPrice;
            txtTotPrice.Text = totPrice.ToString("0.00");
            //Reset UI
            foreach (TextBox txtbox in optionalBoxes)
            {
                txtbox.Clear();
            }
            cboMatches.Enabled = false;
            numberOfSeats.Value = 1;
            btnProcess.Enabled = false;
            cboSeatType.Items.Remove(cboSeatType.SelectedItem);
            cboSeatType.SelectedIndex = -1;
            cboSeatType.Focus();
            grpBoxCart.Visible = true;
            btnCheckOut.Enabled = true;
            lblSeatType.Text = "Seat Type";
            count++;
            // Calculate the total height of the header and data rows
            int headerHeight = dgvCart.ColumnHeadersHeight;
            int rowsHeight = count * dgvCart.Rows[0].Height;
            dgvCart.Height = headerHeight + rowsHeight + 2;
        }

        private void FrmProcessSales_Load(object sender, EventArgs e)
        {
            Match.ShowMatchID(ref allMatchID);
            foreach (string matchID in allMatchID)
            {
                cboMatches.Items.Add(matchID);
            }
        }

        private void CboMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSeatType.Enabled = true;
            SeatType.getAllSeatTypes(ref allSeatTypes);
            if(cboMatches.SelectedIndex != -1)
            {
                foreach (string seatType in allSeatTypes)
                {
                    if (Seat.getTotalNumSeatsLeft(seatType.Substring(0, 3), cboMatches.SelectedItem.ToString().Substring(0, 2)) > 0)
                    {
                        cboSeatType.Items.Add(seatType);
                        cboSeatTypeItems = cboSeatType.Items.Cast<string>().ToArray();
                    }
                    else
                    {
                        continue;
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
                int seatsLeft = Seat.getTotalNumSeatsLeft(cboSeatType.SelectedItem.ToString().Substring(0,3), 
                    cboMatches.SelectedItem.ToString().Substring(0,2));
                Console.WriteLine(seatsLeft);
                if (seatsLeft < 4)
                {
                    numberOfSeats.Maximum = seatsLeft;
                }
                else
                {
                    numberOfSeats.Maximum = 4;
                }
                btnProcess.Enabled = true;
                lblSeatType.Text = $"Seat Type - {cboSeatType.SelectedItem.ToString().Substring(0,3)}";
            }
        }
           
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

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCart.RowCount == 1)
            {
                btnCheckOut.Enabled = false;
                cboMatches.Enabled = true;
            }

            if (e.ColumnIndex == dgvCart.Columns["Cancellation"].Index && e.RowIndex >= 0)
            {
                count--;
                int headerHeight = dgvCart.ColumnHeadersHeight;
                int rowsHeight = count * dgvCart.Rows[e.RowIndex].Height;
                dgvCart.Height = headerHeight + rowsHeight + 2;
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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale(txtName.Text.ToString(), txtEmail.Text.ToString(), DateTime.Now, Convert.ToDouble(txtTotPrice.Text), 
                cboMatches.SelectedItem.ToString().Substring(0, 2));
            sale.AddSale();
            foreach(DataGridViewRow row in dgvCart.Rows)
            {
                string[] seatNums = row.Cells["seatNum"].Value.ToString().Split(',');
                int[] seatNumArr = Array.ConvertAll(seatNums, s => int.Parse(s));
                for(int i = 0; i < seatNumArr.Length; i++)
                {
                    SaleSeat saleSeat = new SaleSeat(sale.SalesID, seatNumArr[i]);
                    saleSeat.addSaleSeat();
                    MatchSeat.UpdateSeatStatus(sale.MatchID,seatNumArr[i]);
                }
            }

            MessageBox.Show("Succesfully purcahse seats", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //reset UI
            // Recalculate and set height of DataGridView
            int headerHeight = dgvCart.ColumnHeadersHeight;
            int rowsHeight = count * dgvCart.Rows[0].Height;
            dgvCart.Height = headerHeight + rowsHeight + 2;

            // Update count
            count--;
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

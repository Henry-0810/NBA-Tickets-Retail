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
        private static double totPrice = 0;
        private static List<string> allMatchID;
        private static List<string> allSeatTypes;
        private static List<double> ChosenSeatNumPrice = new List<double>();
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
            int assignedSeat = Seat.GetLatestUnoccupiedSeatNum(cboSeatType.SelectedItem.ToString(), cboMatches.SelectedItem.ToString().Substring(0, 2));
            string pickedSeats = $"{assignedSeat}";
            for(int i = 1; i <= numberOfSeats.Value-1; i++)
            {
                pickedSeats += $", {assignedSeat + i}";
            }
            Console.WriteLine(pickedSeats);
            double itemPrice = SeatType.getPrice(cboSeatType.SelectedItem.ToString()) * Convert.ToDouble(numberOfSeats.Value);
            dgvCart.Rows.Add(cboSeatType.SelectedItem.ToString(), pickedSeats,
                itemPrice);
            totPrice += itemPrice;
            txtTotPrice.Text = totPrice.ToString();
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
        }

        private void FrmProcessSales_Load(object sender, EventArgs e)
        {
            Match.ShowMatchID(ref allMatchID);
            foreach (string matchID in allMatchID)
            {
                cboMatches.Items.Add(matchID);
            }
            SeatType.getAllSeatTypes(ref allSeatTypes);
            foreach(string seatType in allSeatTypes)
            {
                cboSeatType.Items.Add(seatType);
            }
        }

        private void CboMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSeatType.Enabled = true;
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
                numberOfSeats.Maximum = Sale.getAvailableSeats(cboSeatType.SelectedItem.ToString(), cboMatches.SelectedItem.ToString().Substring(0, 2));
                btnProcess.Enabled = true;
                lblSeatType.Text = $"Seat Type - {cboSeatType.SelectedItem}";
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
            if(e.ColumnIndex == dgvCart.Columns["Cancellation"].Index && e.RowIndex >= 0)
            {
                totPrice -= Convert.ToDouble(dgvCart.Rows[e.RowIndex].Cells[2].Value);
                txtTotPrice.Text = totPrice.ToString();
                cboSeatType.Items.Add(dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString());
                dgvCart.Rows.RemoveAt(e.RowIndex);
            }

            if(e.RowIndex == 0)
            {
                btnCheckOut.Enabled = false;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

    }
}

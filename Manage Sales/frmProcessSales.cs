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
            /*
            //validation
            TextBox[] seatTxtBox = { txtSeat1, txtSeat2, txtSeat3, txtSeat4 };
            for (int i = 0; i < cboSeatType.SelectedIndex + 1; i++)
            { 
                string txtBox = seatTxtBox[i].Text;
                //check null
                if (txtBox.Equals(""))
                {
                    MessageBox.Show("All fields are required to enter!!", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    seatTxtBox[i].Focus();
                    return;
                }
                int isInt;
                bool valid = int.TryParse(txtBox, out isInt);
                //check isDigit
                if (!valid)
                {
                    MessageBox.Show("Seat Number must be an integer", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    seatTxtBox[i].Focus();
                    return;
                }
                //check in range of 1-500
                else if (Convert.ToInt32(txtBox) <= 0 || Convert.ToInt32(txtBox) > 500) 
                {
                    MessageBox.Show("Seat Number must be in range of 1-500", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    seatTxtBox[i].Focus();
                    return;
                }

                List<int> Seats = new List<int> { };
                for(int j = i; j >= 0; j--)
                {
                    Seats.Add(Convert.ToInt32(seatTxtBox[j].Text));
                }
                //check all seat number entered is distinct
                if(new HashSet<int>(Seats).Count() != Seats.Count)
                {
                    MessageBox.Show("Seat Numbers entered cannot be the same", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    seatTxtBox[i].Focus();
                    return;
                }
            }
            //save to class
            for(int i = 0; i < seatTxtBox.Length; i++)
            {
                if(seatTxtBox[i].Text == null || seatTxtBox[i].Text.Equals(""))
                {
                    seatNums.Add(0);
                }
                else
                {
                    seatNums.Add(Convert.ToInt32(seatTxtBox[i].Text));
                }
            }
            int[] seats = seatNums.ToArray();
            for(int i = 0; i < seats.Length; i++)
            {
                ChosenSeatNumPrice.Add(Sale.GetSeatPrice(seats[i]));
            }
            double[] prices = ChosenSeatNumPrice.ToArray();
            double totSales = prices.Sum();
            //check seats availability
            for(int i = 0; i < seats.Length; i++)
            {
                if (MatchSeat.CheckSeatAvailability(cboMatches.SelectedItem.ToString(), seats[i]) == false)
                {
                    if(seats[i] == 0)
                    {
                        continue;
                    }
                    MessageBox.Show($"Seat Number: {seats[i]} is occupied, please choose another seat", "Seat occupied",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    seatTxtBox[i].Focus();
                    return;
                }
                else
                {
                    //if availability validation done, only create object
                    sale = new Sale(txtName.Text, txtEmail.Text, seats, DateTime.Now, totSales,
                        cboMatches.SelectedItem.ToString());
                    sale.AddSales(Convert.ToInt32(cboSeatType.SelectedItem.ToString()));
                    MatchSeat.UpdateSeatStatus(sale.MatchID, sale.Seats[i]);
                }
            }*/
            //Display confirmation message
            //MessageBox.Show("Sales processed\n" + sale.ToString(), "Information", MessageBoxButtons.OK,
            //MessageBoxIcon.Information);

           
            //Reset UI
            foreach(TextBox txtbox in optionalBoxes)
            {
                txtbox.Clear();
            }
            cboMatches.SelectedIndex = -1;
            cboSeatType.SelectedIndex = -1;
            cboSeatType.Enabled = false;
            numberOfSeats.Value = 1;
            btnProcess.Enabled = false;
            cboMatches.Focus();
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
            numberOfSeats.Enabled = true;
            numberOfSeats.Value = 1;
            numberOfSeats.Maximum = Sale.getAvailableSeats(cboSeatType.SelectedItem.ToString(),cboMatches.SelectedItem.ToString().Substring(0,2));
            btnProcess.Enabled = true;
            lblSeatType.Text = $"Seat Type - {cboSeatType.SelectedItem}";
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
    }
}

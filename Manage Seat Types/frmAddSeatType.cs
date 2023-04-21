
using System;

using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmAddSeatType : Form
    {
        private Seat seat;
        private SeatType seatType;
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
            TextBox[] textBoxes = { txtTypeCode, txtDescription, txtPrice, txtNumSeats };
            Label[] labels = { lblTypeCode, lblDesc, lblPrice, lblNumSeats };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text.Equals(""))
                {   
                    string txt = labels[i].Text.ToString().Remove(labels[i].Text.Length - 1);
                    MessageBox.Show(txt + " must be Entered", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtTypeCode.Focus();
                    return;
                }
            }

            double price;
            string strPrice = txtPrice.Text;
            bool valid = double.TryParse(strPrice, out price);
            if (!valid)
            {
                MessageBox.Show("Price must be decimal", "Error!", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (Convert.ToDouble(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Price must be more than 0", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            //check NumSeats is Integer
            foreach(char ch in txtNumSeats.Text)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show(labels[3].Text + " must be integer!", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtNumSeats.Focus();
                    return;
                }
            }

            //save to class
            //create 100 object in next semester
            seatType = new SeatType(txtTypeCode.Text, txtDescription.Text, Convert.ToDouble(txtPrice.Text));
            seatType.AddSeatType();
            int getCurrSeatNum = Seat.getCurrentSeatNum();
            for(int i = getCurrSeatNum; i < Convert.ToInt32(txtNumSeats.Text)+getCurrSeatNum; i++)
            {
                seat = new Seat(i+1, txtTypeCode.Text);
                if (Seat.fullCapacity())
                {
                    MessageBox.Show("Stadium Full!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    Parent.Visible = true;
                    return;
                }
                else
                {
                    seat.addSeat();
                }
            }
            //Display confirmation message
            MessageBox.Show("Seat Type has Been Created\n" + seatType.ToString() + "\nNumber of Seats: " + txtNumSeats.Text, "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            txtTypeCode.Clear();
            txtDescription.Clear(); 
            txtPrice.Text = "0.00";
            txtNumSeats.Text = "";
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
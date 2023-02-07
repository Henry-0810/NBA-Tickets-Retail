
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    public partial class frmUpdateSeatType : Form
    {
        private static new Form Parent;
        SeatType seatType;
        public frmUpdateSeatType(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        

        private void frmUpdateSeatType_Load(object sender, EventArgs e)
        {
            //Load Seat types
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT Type_Code FROM SeatType";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cboSeatTypes.Items.Add(dr.GetString(0));
            }
            dr.Close();
        }

        private void btnUSTback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }
          


        private void cboSeatTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT Descriptions, Price FROM SeatType WHERE Type_Code = '" + cboSeatTypes.SelectedItem.ToString() + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtDescription.Text = dr["Descriptions"].ToString();
                txtPrice.Text = dr["Price"].ToString();
            }
            dr.Close();
            grpType.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            //check validation
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }
            if (Convert.ToDouble(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Price must be more than 0", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            //save to class
            seatType = new SeatType("FR - Front Row", txtDescription.Text, Convert.ToDouble(txtPrice.Text));
            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!!!

            //Display confirmation message
            MessageBox.Show("Seat Type has Been Updated\n" + seatType.ToString(), "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            cboSeatTypes.SelectedIndex = -1;
            txtDescription.Clear();
            txtPrice.Text = "0.00";
            grpType.Visible = false;
            cboSeatTypes.Focus();
        }

        private void frmUpdateSeatType_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }
    }
}

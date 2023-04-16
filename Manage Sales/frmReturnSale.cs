using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace NBA_Tickets_Retail
{
    public partial class frmReturnSale : Form
    {
        private static new Form Parent;
        public frmReturnSale(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnRTback_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void frmReturnTickets_Load(object sender, EventArgs e)
        {
            dgvSale.DataSource = loadSalesData();
            dgvSale.Columns["Total Sales"].DefaultCellStyle.Format = "c";
            foreach(DataGridViewColumn column in dgvSale.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvSale.Height = dgvSale.ColumnHeadersHeight + (5 * dgvSale.Rows[0].Height) + 2;
        }
        
        private void frmReturnTickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        public DataTable loadSalesData()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT s.Sales_ID, s.Cust_Name, s.Cust_Email, s.Sales_Date, " +
                "s.Total_Sales, s.Match_ID, LISTAGG(ss.Seat_Num, ',') WITHIN GROUP (ORDER BY ss.Seat_Num) AS Seat_Num " +
                "FROM Sales s JOIN SaleSeats ss ON s.Sales_ID = ss.Sales_ID JOIN Matches m ON m.Match_ID = s.Match_ID " +
                "WHERE m.Match_Date > SYSDATE GROUP BY s.Sales_ID, s.Cust_Name, s.Cust_Email, " +
                "s.Sales_Date, s.Total_Sales, s.Match_ID"; // Use LISTAGG function to concatenate Seat_Num values into a string

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            dt.Columns["Sales_ID"].ColumnName = "Sales ID";
            dt.Columns["Cust_Name"].ColumnName = "Customer Name";
            dt.Columns["Cust_Email"].ColumnName = "Customer Email";
            dt.Columns["Sales_Date"].ColumnName = "Sales Date";
            dt.Columns["Total_Sales"].ColumnName = "Total Sales";
            dt.Columns["Match_ID"].ColumnName = "Match ID";
            dt.Columns["Seat_Num"].ColumnName = "Seat Number";

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "View Details",
                Name = "btnViewDetails",
                Text = "View",
                UseColumnTextForButtonValue = true
            };
            dgvSale.Columns.Add(btnColumn);

            return dt;
        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSale.Columns["btnViewDetails"].Index && e.RowIndex >= 0)
            {
                grpSaleDetails.Visible = true;
                txtSalesID.Text = dgvSale.Rows[e.RowIndex].Cells["Sales ID"].Value.ToString();
                txtName.Text = dgvSale.Rows[e.RowIndex].Cells["Customer Name"].Value.ToString();
                txtEmail.Text = dgvSale.Rows[e.RowIndex].Cells["Customer Email"].Value.ToString();
                dtPickSalesDate.Value = Convert.ToDateTime(dgvSale.Rows[e.RowIndex].Cells["Sales Date"].Value);
                txtTotSales.Text = $"€{ Convert.ToDecimal(dgvSale.Rows[e.RowIndex].Cells["Total Sales"].Value)}";
                txtMatchID.Text = dgvSale.Rows[e.RowIndex].Cells["Match ID"].Value.ToString();
                txtSeats.Text = dgvSale.Rows[e.RowIndex].Cells["Seat Number"].Value.ToString();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnSale rSale = new ReturnSale(txtName.Text, txtEmail.Text, dtPickSalesDate.Value, 
                Convert.ToDouble(txtTotSales.Text.Substring(1)), txtMatchID.Text);
            SaleSeat.deleteSaleSeat(txtSalesID.Text);
            MessageBox.Show($"Succesfully deleted Sales ID: {txtSalesID.Text}", "Return Sale",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            rSale.addReturnSale();

            //Reset UI
            TextBox[] txtBoxes = { txtSalesID, txtName, txtEmail, txtTotSales, txtMatchID, txtSeats };
            foreach(TextBox textBox in txtBoxes)
            {
                textBox.Clear();
            }
            grpSaleDetails.Visible = false;
        }
    }
}

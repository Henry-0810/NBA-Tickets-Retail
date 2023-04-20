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
            if(dgvSale.Rows.Count > 0)
            {
                dgvSale.Height = dgvSale.ColumnHeadersHeight + (5 * dgvSale.Rows[0].Height) + 2;
            }
        }
        
        private void frmReturnTickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private DataTable loadSalesData()
        {
            OracleConnection conn = Program.getOracleConnection();

            //ListAgg was the one I'm using at home, but the school's version is lower than 11.2 therefore I stacked overflow this
            string sqlQuery = "SELECT s.Sales_ID, s.Cust_Name, s.Cust_Email, s.Sales_Date, " +
                "s.Total_Sales, s.Match_ID, RTRIM(XMLAGG(XMLELEMENT(E, ss.Seat_Num || ',') ORDER BY ss.Seat_Num ASC).EXTRACT('//text()'), ',') AS Seat_Num " +
                "FROM Sales s JOIN SaleSeats ss ON s.Sales_ID = ss.Sales_ID JOIN Matches m ON m.Match_ID = s.Match_ID " +
                "WHERE m.Match_Date > SYSDATE GROUP BY s.Sales_ID, s.Cust_Name, s.Cust_Email, " +
                "s.Sales_Date, s.Total_Sales, s.Match_ID"; 

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
            ReturnSale rSale = new ReturnSale(Convert.ToInt32(txtSalesID.Text.Substring(1).TrimStart('0')), txtName.Text, txtEmail.Text, dtPickSalesDate.Value, 
                Convert.ToDouble(txtTotSales.Text.Substring(1)), txtMatchID.Text);
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to return {txtSalesID.Text}?", "Return Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"Succesfully deleted Sales ID: {txtSalesID.Text}", "Return Sale",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaleSeat.deleteSaleSeat(txtSalesID.Text);
                rSale.addReturnSale();
                string[] seatNums = txtSeats.Text.Split(',');
                for (int i = 0; i < seatNums.Length; i++)
                {
                    MatchSeat.UpdateSeatStatus(txtMatchID.Text, Convert.ToInt32(seatNums[i]));
                }
                dgvSale.Rows.Remove(dgvSale.CurrentRow);
                //Reset UI
                TextBox[] txtBoxes = { txtSalesID, txtName, txtEmail, txtTotSales, txtMatchID, txtSeats };
                foreach (TextBox textBox in txtBoxes)
                {
                    textBox.Clear();
                }
                grpSaleDetails.Visible = false;
            }
            else
            {
                return;
            }
            
        }
    }
}

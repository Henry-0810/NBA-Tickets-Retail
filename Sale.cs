using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    class Sale
    {
        private OracleConnection conn = Program.getOracleConnection();
        private OracleCommand cmd;
        private OracleDataReader dr;
        private string _CustName;
        private string _CustMail;
        private string _salesID;
        private int[] _seats;
        private DateTime _salesDate;
        private double _totalSales;
        private string _matchID;

        public Sale(string custName, string custMail, int[] seats, DateTime salesDate, double totalSales, string matchID)
        {
            CustName = custName;
            CustMail = custMail;
            SalesID = $"S{(GetPreviousSalesID() + 1)}";
            Seats = seats;
            SalesDate = salesDate;
            TotalSales = totalSales;
            MatchID = matchID;
        }

        public string CustName { get => _CustName; set => _CustName = value; }
        public string CustMail { get => _CustMail; set => _CustMail = value; }
        public string SalesID { get => _salesID; set => _salesID = value; }
        public int[] Seats { get => _seats; set => _seats = value; }
        public DateTime SalesDate { get => _salesDate; set => _salesDate = value; }
        public double TotalSales { get => _totalSales; set => _totalSales = value; }
        public string MatchID { get => _matchID; set => _matchID = value; }

        public override string ToString()
        {
            string output = "SalesID: " + SalesID + "\nCustomer Name: " + CustName + "\nCustomer Mail: " + CustMail + 
                "\nMatch ID: " + MatchID + "\nSeat Numbers: ";
            for(int i = 0; i < Seats.Length; i++)
            {
                if (i == Seats.Length - 1)
                {
                    output += Seats[i];
                }
                else
                {
                    output += Seats[i] + ",";
                }
            }
            output += "\nSales Date: " + SalesDate + "\nTotal Sales: " + TotalSales;
            return output;
        }

        public void AddSales(int numPurchasedSeats)
        { 
            string sqlQuery = "INSERT INTO Sales (Sales_ID, Cust_Name, Cust_Email, Seat_1, Seat_2, Seat_3, Seat_4, Sales_Date, Total_Sales, Match_ID) " +
                "VALUES (:SalesID, :CustName, :CustMail, :Seat1, :Seat2, :Seat3, :Seat4, TO_DATE(TO_CHAR(:SalesDate, 'MM/DD/YYYY HH24:MI:SS'), 'MM/DD/YYYY HH24:MI:SS'), :TotSales, :MatchID)";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter(":SalesID", this.SalesID));
            cmd.Parameters.Add(new OracleParameter(":CustName", this.CustName));
            cmd.Parameters.Add(new OracleParameter(":CustMail", this.CustMail));

            for (int i = 1; i <= 4; i++)
            {
                if (i <= numPurchasedSeats)
                {
                    cmd.Parameters.Add(new OracleParameter($":Seat{i}", this.Seats[i - 1]));
                }
                else
                {
                    cmd.Parameters.Add(new OracleParameter($":Seat{i}", DBNull.Value));
                }
            }

            cmd.Parameters.Add(new OracleParameter(":SalesDate", OracleDbType.TimeStamp)).Value = this.SalesDate;
            cmd.Parameters.Add(new OracleParameter(":TotSales", this.TotalSales));
            cmd.Parameters.Add(new OracleParameter(":MatchID", this.MatchID));

            cmd.ExecuteNonQuery();
        }

        public static double GetSeatPrice(int seatNum)
        {
            if(seatNum == 0)
            {
                return 0;
            }
            OracleConnection conn = Program.getOracleConnection();

            string sqlGetPrice = "SELECT st.Price FROM Seats s JOIN SeatTypes st ON s.Type_Code = st.Type_Code " +
                $"WHERE s.Seat_Num = {seatNum}";

            OracleCommand cmd = new OracleCommand(sqlGetPrice, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read() && !dr.IsDBNull(0))
            {
                return dr.GetDouble(0);
            }
            dr.Close();
            return 0;
        }

        public int GetPreviousSalesID()
        {
            string sqlQuery = "SELECT MAX(Sales_ID) FROM Sales";

            cmd = new OracleCommand(sqlQuery, conn);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (!dr.IsDBNull(0) && Int32.TryParse(dr.GetString(0).Substring(1), out int value))
                {
                    return Convert.ToInt32(dr.GetString(0).Substring(1));
                }
                else
                {
                    MessageBox.Show("No sales ID found, have set sales ID as 1", "Getting Sales ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dr.Close();
            return 0;
        }
    }
}

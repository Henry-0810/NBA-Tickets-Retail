using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    //a class that records sale records when the respective sale is return
    class ReturnSale
    {
        private OracleConnection conn = Program.getOracleConnection();
        private OracleCommand cmd;
        private OracleDataReader dr;
        private string _rSalesID;
        private string _custName;
        private string _custMail;
        private DateTime _rSalesDate;
        private double _totalSales;
        private string _matchID;

        public ReturnSale(string custName, string custMail, DateTime rSalesDate, double totalSales, string matchID)
        {
            int returnSalesIDNumeric = GetPreviousReturnSalesID() + 1;
            string returnSalesIDPrefix = "R";
            if (returnSalesIDNumeric >= 1 && returnSalesIDNumeric <= 9)
            {
                RSalesID = $"{returnSalesIDPrefix}00{returnSalesIDNumeric}";
            }
            else if (returnSalesIDNumeric >= 10 && returnSalesIDNumeric <= 99)
            {
                RSalesID = $"{returnSalesIDPrefix}0{returnSalesIDNumeric}";
            }
            else
            {
                RSalesID = $"{returnSalesIDPrefix}{returnSalesIDNumeric}";
            }
            CustName = custName;
            CustMail = custMail;
            RSalesDate = rSalesDate;
            TotalSales = totalSales;
            MatchID = matchID;
        }

        public string RSalesID { get => _rSalesID; set => _rSalesID = value; }
        public string CustName { get => _custName; set => _custName = value; }
        public string CustMail { get => _custMail; set => _custMail = value; }
        public DateTime RSalesDate { get => _rSalesDate; set => _rSalesDate = value; }
        public double TotalSales { get => _totalSales; set => _totalSales = value; }
        public string MatchID { get => _matchID; set => _matchID = value; }

        public override string ToString()
        {
            return $"Return SalesID: {RSalesID}\nCustomer Name: {CustName}\nCustomer Mail: {CustMail}\nMatch ID: {MatchID}\nSales Date: {RSalesDate}\nTotal Sales: { TotalSales}";
        }

        public int GetPreviousReturnSalesID()
        {
            string sqlQuery = "SELECT MAX(Sales_ID) FROM Sales WHERE Sales_ID LIKE 'R%'";

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
                    MessageBox.Show("No Return Sales ID found, have set Return Sales ID as 1", "Getting Return Sales ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dr.Close();
            return 0;
        }

        public void addReturnSale()
        {
            string sqlQuery = "INSERT INTO Sales (Sales_ID, Cust_Name, Cust_Email, Sales_Date, Total_Sales, Match_ID) " +
                "VALUES (:SalesID, :CustName, :CustMail, TO_DATE(TO_CHAR(:SalesDate, 'MM/DD/YYYY HH24:MI:SS'), 'MM/DD/YYYY HH24:MI:SS'), :TotSales, :MatchID)";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter(":SalesID", this.RSalesID));
            cmd.Parameters.Add(new OracleParameter(":CustName", this.CustName));
            cmd.Parameters.Add(new OracleParameter(":CustMail", this.CustMail));
            cmd.Parameters.Add(new OracleParameter(":SalesDate", OracleDbType.TimeStamp)).Value = this.RSalesDate;
            cmd.Parameters.Add(new OracleParameter(":TotSales", this.TotalSales));
            cmd.Parameters.Add(new OracleParameter(":MatchID", this.MatchID));

            cmd.ExecuteNonQuery();
        }
    }
}


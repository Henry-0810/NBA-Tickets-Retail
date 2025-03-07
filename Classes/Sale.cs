﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    class Sale
    {
        private OracleConnection conn = Program.getOracleConnection();
        private OracleCommand cmd;
        private OracleDataReader dr;
        private string _salesID;
        private string _CustName;
        private string _CustMail;
        private DateTime _salesDate;
        private double _totalSales;
        private string _matchID;

        public Sale(string custName, string custMail, DateTime salesDate, double totalSales, string matchID)
        {
            CustName = custName;
            CustMail = custMail;
            int salesIDNumeric = getPreviousSalesID() + 1;
            string salesIDPrefix = "S";
            //To prevent lexical order
            if (salesIDNumeric >= 1 && salesIDNumeric <= 9)
            {
                SalesID = $"{salesIDPrefix}00{salesIDNumeric}";
            }
            else if(salesIDNumeric >= 10 && salesIDNumeric <= 99)
            {
                SalesID = $"{salesIDPrefix}0{salesIDNumeric}";
            }
            else
            {
                SalesID = $"{salesIDPrefix}{salesIDNumeric}";
            }
            SalesDate = salesDate;
            TotalSales = totalSales;
            MatchID = matchID;
        }

        public string SalesID { get => _salesID; set => _salesID = value; }
        public string CustName { get => _CustName; set => _CustName = value; }
        public string CustMail { get => _CustMail; set => _CustMail = value; }
        public DateTime SalesDate { get => _salesDate; set => _salesDate = value; }
        public double TotalSales { get => _totalSales; set => _totalSales = value; }
        public string MatchID { get => _matchID; set => _matchID = value; }

        public override string ToString()
        {
            return $"SalesID: {SalesID}\nCustomer Name: {CustName}\nCustomer Mail: {CustMail}\nMatch ID: {MatchID}\nSales Date: {SalesDate}\nTotal Sales: { TotalSales}";
        }

        //Adds a sale record to the Sales table
        public void addSale()
        {
            string sqlQuery = "INSERT INTO Sales (Sales_ID, Cust_Name, Cust_Email, Sales_Date, Total_Sales, Match_ID) " +
                "VALUES (:SalesID, :CustName, :CustMail, TO_DATE(TO_CHAR(:SalesDate, 'MM/DD/YYYY HH24:MI:SS'), 'MM/DD/YYYY HH24:MI:SS'), :TotSales, :MatchID)";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter(":SalesID", this.SalesID));
            cmd.Parameters.Add(new OracleParameter(":CustName", this.CustName));
            cmd.Parameters.Add(new OracleParameter(":CustMail", this.CustMail));
            cmd.Parameters.Add(new OracleParameter(":SalesDate", OracleDbType.TimeStamp)).Value = this.SalesDate;
            cmd.Parameters.Add(new OracleParameter(":TotSales", this.TotalSales));
            cmd.Parameters.Add(new OracleParameter(":MatchID", this.MatchID));

            cmd.ExecuteNonQuery();
        }

        //Check if Sales table is empty
        public static int isSalesEmpty()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(*) FROM Sales";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //Gets the previous sales_ID that starts with letter 'S', this prevents primary key violation
        private int getPreviousSalesID()
        {
            string sqlQuery = "SELECT MAX(Sales_ID) FROM Sales WHERE Sales_ID LIKE 'S%'";

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

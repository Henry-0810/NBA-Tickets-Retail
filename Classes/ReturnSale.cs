﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    //a class that saves return sale records when the respective sale is returned
    class ReturnSale
    {
        private OracleConnection conn = Program.getOracleConnection();
        private OracleCommand cmd;
        private string _rSalesID;
        private string _custName;
        private string _custMail;
        private DateTime _rSalesDate;
        private double _totalSales;
        private string _matchID;

        public ReturnSale(int rSalesID, string custName, string custMail, DateTime rSalesDate, double totalSales, string matchID)
        {
            string returnSalesIDPrefix = "RS";
            //To prevent lexical order
            if (rSalesID >= 1 && rSalesID <= 9)
            {
                RSalesID = $"{returnSalesIDPrefix}00{rSalesID}";
            }
            else if (rSalesID >= 10 && rSalesID <= 99)
            {
                RSalesID = $"{returnSalesIDPrefix}0{rSalesID}";
            }
            else
            {
                RSalesID = $"{returnSalesIDPrefix}{rSalesID}";
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

        //Adds a return sale record to the Sales table
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


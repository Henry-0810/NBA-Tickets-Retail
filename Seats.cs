﻿
using Oracle.ManagedDataAccess.Client;


namespace NBA_Tickets_Retail
{
    class Seats
    {
        private string _SeatID;
        private string _TypeCode;
        private string _Status;
        private static int count = 0;

        public Seats()
        {
            SeatID = "0";
            TypeCode = "None";
            Status = "U";
        }
        public Seats(string typeCode, string status)
        {
            SeatID = typeCode+"-"+(count++.ToString());
            TypeCode = typeCode;
            Status = status;
        }

        public string SeatID
        {
            get => _SeatID;
            set { _SeatID = value; }
        }
        public string TypeCode { get => _TypeCode; set => _TypeCode = value; }
        public string Status { get => _Status; set => _Status = value; }

        public override string ToString()
        {
            return "SeatID: " + SeatID + "\nTypeCode: " + TypeCode + "\nStatus: " + Status;
        }

        public void addSeat()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "INSERT INTO Seats Values ('" +
                this.SeatID + "','" + this.TypeCode + "','" + this.Status
                + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public void emptySeat()
        {
            
        }
    }
}

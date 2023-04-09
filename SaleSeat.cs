using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Tickets_Retail
{
    class SaleSeat
    {
        private string _SaleID;
        private int _SeatNum;

        public SaleSeat(string saleID, int seatNum)
        {
            SaleID = saleID;
            SeatNum = seatNum;
        }

        public string SaleID { get => _SaleID; set => _SaleID = value; }
        public int SeatNum { get => _SeatNum; set => _SeatNum = value; }

        public void addSaleSeat()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"INSERT INTO SaleSeats (Sales_ID, Seat_Num) VALUES ('{this.SaleID}', {this.SeatNum})";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }
    }
}

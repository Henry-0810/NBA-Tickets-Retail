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
        OracleConnection conn = Program.getOracleConnection();
        OracleCommand cmd;
        OracleDataReader dr;
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
            string sqlQuery = $"INSERT INTO SaleSeats (Sales_ID, Seat_Num) VALUES ('{this.SaleID}', {this.SeatNum})";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public static string[] getSaleSeat(string saleID)
        {
            List<string> seats = new List<string>();
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"SELECT Seat_Num FROM SaleSeats WHERE Sales_ID = '{saleID}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read() && getSaleSeatCount(saleID) > 0)
            {
                for(int i = 0; i < getSaleSeatCount(saleID); i++)
                {
                    seats.Add(dr["Seat_Num"].ToString());
                }
            }
            dr.Close();
            return null;
        }

        public static int getSaleSeatCount(string saleID)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"SELECT COUNT(Seat_Num) FROM SaleSeats WHERE Sales_ID = '{saleID}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read() && !dr.IsDBNull(0))
            {
                return dr.GetInt32(0);
            }

            dr.Close();
            return 0;
        }

        public static void deleteSaleSeat(string saleID)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"DELETE FROM SaleSeats WHERE Sales_ID = '{saleID}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }
    }
}

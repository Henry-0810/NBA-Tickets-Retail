using Oracle.ManagedDataAccess.Client;
using System;

namespace NBA_Tickets_Retail
{
    class Seat
    {
        private int _seatNum;
        private string _TypeCode;
       
        public Seat(int seatNum, string typeCode)
        {
            SeatNum = seatNum;
            TypeCode = typeCode;
        }

        public int SeatNum { get => _seatNum; set => _seatNum = value; }
        public string TypeCode { get => _TypeCode; set => _TypeCode = value; }
      

        public override string ToString()
        {
            return "Type Code: " + TypeCode;
        }

        public void AddSeat()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"INSERT INTO Seats Values ({this.SeatNum},'{this.TypeCode}')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public static bool FullCapacity()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT MAX(Seat_Num) FROM Seats";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                return false;
            }
            else
            {
                if(dr.GetInt32(0)+1 <= 50)
                {
                    return false;
                }
                else { return true; }
            }
        }

        public static int GetCurrentSeatNum()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT MAX(Seat_Num) FROM Seats";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
            {
                return 0;
            }
            int currSeats = dr.GetInt32(0);
            dr.Close();
            return currSeats;
        }

        public static int GetLatestUnoccupiedSeatNum(string seatType, string matchID)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT MIN(s.Seat_Num) FROM Seats s " + 
                              "JOIN MatchSeats ms ON s.SEAT_Num = ms.SEAT_Num " + 
                              "LEFT JOIN SaleSeats ss ON s.SEAT_Num = ss.SEAT_Num " +
                              $"WHERE s.Type_Code = '{seatType}' AND ms.Status = 'U' AND " +
                              $"ms.Match_ID = '{matchID}' AND ss.Seat_Num IS NULL";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read() && !dr.IsDBNull(0))
            {
                return dr.GetInt32(0);
            }

            return 0;
        }

        public static int GetSeatsCount()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(*) FROM Seats";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static int getTotalNumSeatsLeft(string seatType, string matchID)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(s.Seat_Num) FROM Seats s " +
                              "JOIN MatchSeats ms ON s.SEAT_Num = ms.SEAT_Num " +
                              "LEFT JOIN SaleSeats ss ON s.SEAT_Num = ss.SEAT_Num " +
                              $"WHERE s.Type_Code = '{seatType}' AND ms.Status = 'U' AND " +
                              $"ms.Match_ID = '{matchID}' AND ss.Seat_Num IS NULL";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            if(cmd.ExecuteScalar() != null)
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

            return 0;
        }
    }
}

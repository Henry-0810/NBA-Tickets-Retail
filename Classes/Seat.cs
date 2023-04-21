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

        //Adds a seat record to the Seats table
        public void addSeat()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"INSERT INTO Seats Values ({this.SeatNum},'{this.TypeCode}')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        //Check if the seats have reached their full capacity, as a stadium has limited space
        public static bool fullCapacity()
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
                if(dr.GetInt32(0)+1 <= 100)
                {
                    return false;
                }
                else { return true; }
            }
        }

        //Gets the latest seat number from the Seats table, this is to prevent primary key violation
        public static int getCurrentSeatNum()
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

        //Gets the latest seat number of a seat type for a match where the status is 'U' (Unoccupied)
        public static int getLatestUnoccupiedSeatNum(string seatType, string matchID)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT Min(ms.Seat_Num) FROM MatchSeats ms " +
                "JOIN Seats s ON ms.Seat_Num = s.Seat_Num " +
                "LEFT JOIN SaleSeats ss ON ms.Seat_Num = ss.Seat_Num " +
                "LEFT JOIN Sales sa ON ss.Sales_ID = sa.Sales_ID " +
                "WHERE ms.Status = 'U' AND ms.Match_ID = :matchID AND s.Type_Code = :seatType " +
                "AND (sa.Match_ID IS NULL OR sa.Match_ID <> ms.Match_ID)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter(":matchID", matchID));
            cmd.Parameters.Add(new OracleParameter(":seatType", seatType));

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read() && !dr.IsDBNull(0))
            {
                return dr.GetInt32(0);
            }

            return 0;
        }

        //Gets the number of records in the Seats table 
        public static int getSeatsCount()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(*) FROM Seats";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //Gets the number of seats left for a seat type in a particular match 
        public static int getTotalNumSeatsLeft(string seatType, string matchID)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(ms.Seat_Num) FROM MatchSeats ms " +
                "JOIN Seats s ON ms.Seat_Num = s.Seat_Num " +
                "LEFT JOIN SaleSeats ss ON ms.Seat_Num = ss.Seat_Num " +
                "LEFT JOIN Sales sa ON ss.Sales_ID = sa.Sales_ID " +
                "WHERE ms.Status = 'U' AND ms.Match_ID = :matchID AND s.Type_Code = :seatType " +
                "AND (sa.Match_ID IS NULL OR sa.Match_ID <> ms.Match_ID)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter(":matchID", matchID));
            cmd.Parameters.Add(new OracleParameter(":seatType", seatType));

            if (cmd.ExecuteScalar() != null)
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

            return 0;
        }
    }
}

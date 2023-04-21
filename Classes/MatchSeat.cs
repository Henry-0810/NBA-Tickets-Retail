using Oracle.ManagedDataAccess.Client;
using System;

namespace NBA_Tickets_Retail
{
    class MatchSeat
    {
        private OracleConnection conn = Program.getOracleConnection();
        private OracleCommand cmd;
        private string _MSS_ID;
        private string _MatchID;
        private int _Seat_Num;
        private string _Status;

        //Status will be 'U' by default
        public MatchSeat(string matchID, int seatNum)
        {
            _MSS_ID = $"{matchID}-{seatNum}";
            _MatchID = matchID;
            _Seat_Num = seatNum;
            _Status = "U";
        }

        public string MSS_ID { get => _MSS_ID; set => _MSS_ID = value; }
        public string MatchID { get => _MatchID; set => _MatchID = value; }
        public int SeatNum { get => _Seat_Num; set => _Seat_Num = value; }
        public string Status { get => _Status; set => _Status = value; }

        //Adds a matchSeat record to the MatchSeats table
        public void addMatchSeat()
        {
            string sqlQuery = $"INSERT INTO MatchSeats (MSS_ID, Match_ID, Seat_Num) VALUES ('{this.MSS_ID}','{this.MatchID}'" +
                $",{this.SeatNum})";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        //Updates the status of matchSeat from 'U' to 'O' and vice versa from the MatchSeats table
        public static void updateSeatStatus(string MatchID, int seatNum)
        {
            OracleConnection conn = Program.getOracleConnection();
            string sqlQuery = $"SELECT Status FROM MatchSeats WHERE MSS_ID = '{MatchID}-{seatNum}'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string currentStatus = dr.GetString(0);
                dr.Close();
                string newStatus;
                if (currentStatus == "O")
                {
                    newStatus = "U";
                }
                else if (currentStatus == "U")
                {
                    newStatus = "O";
                }
                else
                {
                    throw new Exception("Invalid status");
                }
                sqlQuery = $"UPDATE MatchSeats SET Status = '{newStatus}' WHERE MSS_ID = '{MatchID}-{seatNum}'";
                cmd = new OracleCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                dr.Close();
                throw new Exception("Seat not found");
            }
        }
    }
}
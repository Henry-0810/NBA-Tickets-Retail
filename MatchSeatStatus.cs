
using Oracle.ManagedDataAccess.Client;


namespace NBA_Tickets_Retail
{
    class MatchSeatStatus
    {
        private OracleConnection conn = Program.getOracleConnection();
        private OracleCommand cmd;
        private OracleDataReader dr;
        private string _MSS_ID;
        private string _Match_ID;
        private int _Seat_Num;
        private string _Status;

        public MatchSeatStatus(string match_ID, int seat_Num)
        {
            _MSS_ID = $"{match_ID}-{seat_Num}";
            _Match_ID = match_ID;
            _Seat_Num = seat_Num;
            _Status = "U";
        }

        public string MSS_ID { get => _MSS_ID; set => _MSS_ID = value; }
        public string Match_ID { get => _Match_ID; set => _Match_ID = value; }
        public int Seat_Num { get => _Seat_Num; set => _Seat_Num = value; }
        public string Status { get => _Status; set => _Status = value; }

        public void addMatchSeatStatus()
        {
            string sqlQuery = $"INSERT INTO MatchSeatStatus (MSS_ID, Match_ID, Seat_Num) VALUES ('{this.MSS_ID}','{this.Match_ID}'" +
                $",{this.Seat_Num})";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public static void updateSeatStatus(string MatchID, int seatNum)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"UPDATE MatchSeatStatus SET Status = 'O' WHERE MSS_ID = '{MatchID}-{seatNum}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public static bool checkSeatAvailability(string MatchID, int seatNum)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"SELECT Status FROM MatchSeatStatus WHERE MSS_ID = '{MatchID}-{seatNum}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read() && !dr.IsDBNull(0))
            {
                string status = dr.GetString(0);
                if (status.Equals("U")) return true;
                else return false;
            }
            dr.Close();
            return false;
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    class Match
    {
        private OracleConnection conn = Program.getOracleConnection();
        private OracleCommand cmd;
        private OracleDataReader dr;
        private MatchSeat matchSeat;
        private string _MatchID;
        private string _matchDate;
        private string _matchTime;
        private string _homeTeam;
        private string _teamID;

        public Match(string matchDate, string matchTime, string teamID)
        {
            int matchIDNumeric = getPreviousMatchID() + 1;
            if(matchIDNumeric >= 1 && matchIDNumeric <= 9)
            {
                MatchID = $"M0{matchIDNumeric}";
            }
            else
            {
                MatchID = $"M{matchIDNumeric}";
            }
            MatchDate = matchDate;
            MatchTime = matchTime;
            HomeTeam = "";
            TeamID = teamID;
        }

        public string MatchID
        {
            get => _MatchID;
            set => _MatchID = value;
        }
        public string MatchTime { get => _matchTime; set => _matchTime = value; }
        public string HomeTeam
        {
            get => _homeTeam;
            set { _homeTeam = "Golden State Warriros"; }
        }
        public string TeamID { 
            get => _teamID; 
            set => _teamID = value; 
        }
        public string MatchDate { get => _matchDate; set => _matchDate = value; }

        public override string ToString()
        {
            return "MatchID: " + MatchID + "\nMatch Time " + MatchTime + "\nHome Team: " + 
                HomeTeam;
        }

        //Adds a match record to the Matches table
        public void addMatch()
        {
            string sqlQuery = $"INSERT INTO Matches Values ('{this.MatchID}'," +
                $"TO_DATE('{this.MatchDate}','YYYY-MM-DD'),'{this.MatchTime}','{this.TeamID}')";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            //Gets the number of seats and creates the same number of matchSeats with that current matchID
            //Now each seat number in each match is distinct
            for(int i = 1; i <= Seat.getSeatsCount(); i++)
            {
                matchSeat = new MatchSeat(this.MatchID, i);
                matchSeat.AddMatchSeat();
            }
        }

        public static void showMatchDetails(ref List<string> allMatchID)
        {
            allMatchID = new List<string>();
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT m.Match_ID, t.Team_Name FROM Matches m JOIN Teams t ON m.Team_ID = t.Team_ID " +
                $"WHERE m.Match_Date >= TO_DATE('{DateTime.Today:dd-MMM-yy}', 'dd-MON-yy') ORDER BY t.Team_Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                    string matchID = $"{dr.GetString(0)} - {dr.GetString(1)}";
                    
                    allMatchID.Add(matchID);
            }

            dr.Close();
        }

        public static int getMatchesCount()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(*) FROM Matches";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private int getPreviousMatchID()
        {
            string sqlQuery = "SELECT MAX(Match_ID) FROM Matches";

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
                    MessageBox.Show("No match ID found, have set match ID as 1", "Getting Match ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dr.Close();
            return 0;
        }
    }
}

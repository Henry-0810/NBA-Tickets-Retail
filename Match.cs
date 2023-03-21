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
        private MatchSeatStatus matchSeatStatus;
        private string _MatchID;
        private string _matchTime;
        private string _homeTeam;
        private string _awayTeamID;

        public Match(string matchTime, string awayTeamID)
        {
            MatchID = $"M{(GetPreviousMatchID() + 1)}";
            MatchTime = matchTime;
            HomeTeam = "";
            AwayTeamID = awayTeamID;
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
        public string AwayTeamID { 
            get => _awayTeamID; 
            set => _awayTeamID = value; 
        }

        public override string ToString()
        {
            return "MatchID: " + MatchID + "\nMatch Time " + MatchTime + "\nHome Team: " + 
                HomeTeam + "\nAway Team: " + AwayTeamID ;
        }

        public void AddMatches()
        {
            string sqlQuery = $"INSERT INTO Matches Values ('{this.MatchID}'," +
                $"TO_DATE('{this.MatchTime}','YYYY-MM-DD'),'{this.AwayTeamID}')";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            for(int i = 1; i <= 500; i++)
            {
                matchSeatStatus = new MatchSeatStatus("M" + GetPreviousMatchID().ToString(), i);
                matchSeatStatus.AddMatchSeatStatus();
            }
        }

        public int GetPreviousMatchID()
        {
            string sqlQuery = "SELECT MAX(Match_ID) FROM Matches";

            cmd = new OracleCommand(sqlQuery, conn);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (!dr.IsDBNull(0) && Int32.TryParse(dr.GetString(0).Substring(1),out int value))
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

        public static void ShowMatchID(ref List<string> allMatchID)
        {
            allMatchID = new List<string>();
            OracleConnection conn = Program.getOracleConnection();

            string sqlMatchID = "SELECT Match_ID FROM Matches";

            OracleCommand cmd = new OracleCommand(sqlMatchID, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read() && !dr.IsDBNull(0))
            {
                    string matchID = dr.GetString(0);

                    allMatchID.Add(matchID);
            }

            dr.Close();
        }
    }
}

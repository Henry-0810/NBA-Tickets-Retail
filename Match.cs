﻿using Oracle.ManagedDataAccess.Client;
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
        private MatchSeat matchSeatStatus;
        private string _MatchID;
        private string _matchDate;
        private string _matchTime;
        private string _homeTeam;
        private string _awayTeamID;

        public Match(string matchDate, string matchTime, string awayTeamID)
        {
            MatchID = $"M{(GetPreviousMatchID() + 1)}";
            MatchDate = matchDate;
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
        public string MatchDate { get => _matchDate; set => _matchDate = value; }

        public override string ToString()
        {
            return "MatchID: " + MatchID + "\nMatch Time " + MatchTime + "\nHome Team: " + 
                HomeTeam;
        }

        public void AddMatches()
        {
            string sqlQuery = $"INSERT INTO Matches Values ('{this.MatchID}'," +
                $"TO_DATE('{this.MatchDate}','YYYY-MM-DD'),'{this.MatchTime}','{this.AwayTeamID}')";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            for(int i = 1; i <= 50; i++)
            {
                matchSeatStatus = new MatchSeat("M" + GetPreviousMatchID().ToString(), i);
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

        public static int isMatchEmpty()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(*) FROM Matches";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}

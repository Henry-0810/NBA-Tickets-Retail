using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace NBA_Tickets_Retail
{
    class AwayTeam
    {
        private string _awayTeamID;
        private string _teamName;

        public AwayTeam(string awayTeamID, string teamName)
        {
            AwayTeamID = awayTeamID;
            TeamName = teamName;
        }

        public string AwayTeamID { get => _awayTeamID; set => _awayTeamID = value; }
        public string TeamName { get => _teamName; set => _teamName = value; }

        public override string ToString()
        {
            return AwayTeamID + " - " + TeamName;
        }

        public void addTeam()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "INSERT INTO Teams (Team_ID, Team_Name) Values ('"
                + this.AwayTeamID + "','" + this.TeamName + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public static void viewAllTeams(ref List<AwayTeam> allTeams)
        {
            allTeams = new List<AwayTeam>();
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT * FROM Teams ORDER BY Team_Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string team_ID = dr.GetString(0);
                string team_Name = dr.GetString(1);

                allTeams.Add(new AwayTeam(team_ID, team_Name));
            }

            dr.Close();
        }

        public static int isTeamsEmpty()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(*) FROM Teams";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}

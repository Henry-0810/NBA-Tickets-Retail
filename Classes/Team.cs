using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NBA_Tickets_Retail
{
    class Team
    {
        private string _teamID;
        private string _teamName;

        public Team(string teamID, string teamName)
        {
            TeamID = teamID;
            TeamName = teamName;
        }

        public string TeamID { get => _teamID; set => _teamID = value; }
        public string TeamName { get => _teamName; set => _teamName = value; }

        public override string ToString()
        {
            return TeamID + " - " + TeamName;
        }

        public void addTeam()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "INSERT INTO Teams (Team_ID, Team_Name) Values ('"
                + this.TeamID + "','" + this.TeamName + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public static void viewAllTeams(ref List<Team> allTeams)
        {
            allTeams = new List<Team>();
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT * FROM Teams ORDER BY Team_Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string team_ID = dr.GetString(0);
                string team_Name = dr.GetString(1);

                allTeams.Add(new Team(team_ID, team_Name));
            }

            

            dr.Close();
        }

        public static int getTeamsCount()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(*) FROM Teams";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}

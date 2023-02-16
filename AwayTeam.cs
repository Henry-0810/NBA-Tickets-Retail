using Oracle.ManagedDataAccess.Client;

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
            return "Team ID: " + AwayTeamID + "\nTeam Name: " + TeamName;
        }

        public void addTeam()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "INSERT INTO Teams (Team_ID, Team_Name) Values ('"
                + this.AwayTeamID + "','" + this.TeamName + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }
    }
}

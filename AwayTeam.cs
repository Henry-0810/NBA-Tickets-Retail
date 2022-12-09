using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Tickets_Retail
{
    class AwayTeam
    {
        private int _awayTeamID;
        private string _teamName;

        public AwayTeam(int awayTeamID, string teamName)
        {
            AwayTeamID = awayTeamID;
            TeamName = teamName;
        }

        public int AwayTeamID { get => _awayTeamID; set => _awayTeamID = value; }
        public string TeamName { get => _teamName; set => _teamName = value; }
    }
}

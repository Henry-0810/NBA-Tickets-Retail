using System;


namespace NBA_Tickets_Retail
{
    class Match
    {
        private int _MatchID;
        private DateTime _matchTime;
        private String _homeTeam;
        private int _awayTeamID;

        public Match(int matchID, DateTime matchTime, int awayTeamID)
        {
            MatchID = matchID;
            MatchTime = matchTime;
            HomeTeam = "";
            AwayTeamID = awayTeamID;
        }

        public int MatchID
        {
            get => _MatchID;
            set => _MatchID = value;
        }
        public DateTime MatchTime { get => _matchTime; set => _matchTime = value; }
        public string HomeTeam
        {
            get => _homeTeam;
            set { _homeTeam = "Golden State Warriros"; }
        }
        public int AwayTeamID { get => _awayTeamID; set => _awayTeamID = value; }

        public override string ToString()
        {
            return "MatchID: " + MatchID + "\nMatch Time " + MatchTime + "\nHome Team: " + 
                HomeTeam + "\nAway Team: " + AwayTeamID ;
        }
    }
}

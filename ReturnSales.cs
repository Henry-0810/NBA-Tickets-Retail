using System;


namespace NBA_Tickets_Retail
{
    //a class that records sale records when the respective sale is return
    class ReturnSales
    {
        private string r_salesID;
        private int _seat1;
        private int _seat2;
        private int _seat3;
        private int _seat4;
        private DateTime _salesDate;
        private double _totalSales;
        private int _matchID;
        private static int count = 0;

        public ReturnSales(int seat1, int seat2, int seat3, int seat4, int matchID)
        {
            R_SalesID = "";
            Seat1 = seat1;
            Seat2 = seat2;
            Seat3 = seat3;
            Seat4 = seat4;
            SalesDate = DateTime.Now;
            TotalSales = _totalSales;
            MatchID = matchID;
        }

        public string R_SalesID
        {
            get => r_salesID;
            set
            {
                r_salesID = (++count).ToString();
            }
        }
        public int Seat1 { get => _seat1; set => _seat1 = value; }
        public int Seat2 { get => _seat2; set => _seat2 = value; }
        public int Seat3 { get => _seat3; set => _seat3 = value; }
        public int Seat4 { get => _seat4; set => _seat4 = value; }
        public DateTime SalesDate
        {
            get => _salesDate;
            set
            {
                _salesDate = DateTime.Now;
            }
        }
        public double TotalSales
        {
            get => _totalSales;
            set => _totalSales = value;
        }
        public int MatchID { get => _matchID; set => _matchID = value; }
    }
}


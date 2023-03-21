using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Tickets_Retail
{
    class SaleSeat
    {
        private string _SaleID;
        private int _SeatNum;

        public SaleSeat(string saleID, int seatNum)
        {
            SaleID = saleID;
            SeatNum = seatNum;
        }

        public string SaleID { get => _SaleID; set => _SaleID = value; }
        public int SeatNum { get => _SeatNum; set => _SeatNum = value; }


    }
}

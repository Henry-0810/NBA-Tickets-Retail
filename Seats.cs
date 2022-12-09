using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Tickets_Retail
{
    class Seats
    {
        private int _SeatID;
        private string _TypeCode;
        private string _Status;

        public Seats(int seatID, string typeCode, string status)
        {
            SeatID = seatID;
            TypeCode = typeCode;
            Status = status;
        }

        public int SeatID { get => _SeatID; set => _SeatID = value; }
        public string TypeCode { get => _TypeCode; set => _TypeCode = value; }
        public string Status { get => _Status; set => _Status = value; }
    }
}

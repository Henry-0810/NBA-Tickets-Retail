using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Tickets_Retail
{
    class SeatType
    {
        private string _TypeCode;
        private string _description;
        private double _price;

        public SeatType(string typeCode, string description, double price)
        {
            TypeCode = typeCode;
            Description = description;
            Price = price;
        }

        public string TypeCode { get => _TypeCode; set => _TypeCode = value; }
        public string Description { get => _description; set => _description = value; }
        public double Price { get => _price; set => _price = value; }

        public override string ToString()
        {
            return "Type Code: " + TypeCode + "\nDescription: " + Description + "\nPrice: " + Price;
        }
    }
}

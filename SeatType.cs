using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace NBA_Tickets_Retail
{
    class SeatType
    {
        private Seats seats;
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

        public void addSeatType()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "INSERT INTO SeatType Values ('" +
                this.TypeCode + "','" +
                this.Description + "'," +
                this.Price + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
            for(int i = 1; i <= 100; i++)
            {
                seats = new Seats(this.TypeCode.ToString(), "U");
                seats.addSeat();
            }
            
        }

        public string[] retrieveSeatType()
        {
            List<string> typeCodeName = new List<string>();
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT Type_Code FROM SeatType";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                typeCodeName.Add(dr.GetString(0));
            }
            dr.Close();
            string[] typeCodeArr = typeCodeName.ToArray();
            return typeCodeArr;
        }
    }
}

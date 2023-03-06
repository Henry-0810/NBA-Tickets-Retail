

using Oracle.ManagedDataAccess.Client;

namespace NBA_Tickets_Retail
{
    class SeatTypes
    {
        private string _TypeCode;
        private string _description;
        private double _price;
        //My seat types in database
        //LLS - Lower-Level Sideline, ideal angle for game action - 250 - 80
        //CS - Courtside, expensive but nearest to the players - 800 - 100
        //CL - Club-Level seats, exclusive lounges, bars - 950 - 60
        //UPS - Upper-Level Sideline, budget but elegant - 150 - 130
        //BTB - Behind the basket, best seats for families - 200 - 130

        public SeatTypes( string typeCode, string description, double price)
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

            string sqlQuery = "INSERT INTO SeatTypes (Type_Code, Description, Price) Values ('" +
                this.TypeCode + "','" +
                this.Description + "'," +
                this.Price + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }
        public void updateSeatType()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "UPDATE SeatTypes SET Description = '" +
                this.Description + "',Price = " +
                this.Price + " WHERE Type_Code = '" + this.TypeCode + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }
    }
}

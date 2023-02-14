using Oracle.ManagedDataAccess.Client;


namespace NBA_Tickets_Retail
{
    class SeatTypes
    {
        private Seats seats;
        private string _TypeCode;
        private string _description;
        private double _price;
        //My seat types in database
        //LLS - Lower-Level Sideline, ideal angle for game action - 250
        //CS - Courtside, expensive but nearest to the players - 800
        //CL - Club-Level seats, exclusive lounges, bars - 950
        //UPS - Upper-Level Sideline, budget but elegant - 150
        //BTB - Behind the basket, best seats for families - 200
        public SeatTypes(string typeCode, string description, double price)
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

            for(int i = 1; i <= 100; i++)
            {
                seats = new Seats(this.TypeCode.ToString(), "U");
                seats.addSeat();
            }
            
        }

        public void updateSeatType()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "UPDATE SeatTypes SET Description = '" +
                this.Description + "',Price = " +
                this.Price + " WHERE Type_Code = '" + this.TypeCode +"'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public static bool fullCapacity()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT SUM(Num_Seats) FROM SeatTypes";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                return false;
            }
            else
            {
                if(dr.GetInt32(0) <= 200)
                {
                    return false;
                }
                else { return true; }
            }
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace NBA_Tickets_Retail
{
    class SeatType
    {
        private OracleConnection conn = Program.getOracleConnection();
        private OracleCommand cmd;
        private string _TypeCode;
        private string _description;
        private double _price;
        //My seat types in database
        //LLS - Lower-Level Sideline - 250 - 10
        //CTS - Courtside - 800 - 10
        //CLL - Club-Level seats - 950 - 10
        //UPS - Upper-Level Sideline - 150 - 10
        //BTB - Behind the basket - 200 - 10

        public SeatType( string typeCode, string description, double price)
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

        public void AddSeatType()
        { 
            string sqlQuery = $"INSERT INTO SeatTypes (Type_Code, Description, Price) Values ('{this.TypeCode}'," +
                $"'{this.Description}',{this.Price})";
        
            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public void UpdateSeatType()
        {
            string sqlQuery = $"UPDATE SeatTypes SET Description = '{this.Description}',Price = {this.Price} " +
                $"WHERE Type_Code = '{this.TypeCode}'";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            SaleSeat.updateNewPrice(this.TypeCode);
        }

        public static void getAllSeatTypes(ref List<string> allSeatTypes)
        {
            allSeatTypes = new List<string>();
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT Type_Code, Description FROM SeatTypes";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read() && !dr.IsDBNull(0))
            {
                string seatType = $"{dr.GetString(0)} - {dr.GetString(1)}";

                allSeatTypes.Add(seatType);
            }

            dr.Close();
        }

        public static int getSeatTypesCount()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT COUNT(*) FROM SeatTypes";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static double getPrice(string seatType)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"SELECT Price FROM SeatTypes WHERE Type_Code = '{seatType}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read() && !dr.IsDBNull(0))
            {
                return dr.GetDouble(0);
            }
            return 0;
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;

namespace NBA_Tickets_Retail
{
    class SaleSeat
    {
        OracleConnection conn = Program.getOracleConnection();
        OracleCommand cmd;
        OracleDataReader dr;
        private string _SaleID;
        private int _SeatNum;
        private double _OriginalPrice;
        private double _NewPrice;

        //NewPrice will be set to 0 by default when updating a seat type's price; only NewPrice will be updated
        public SaleSeat(string saleID, int seatNum)
        {
            SaleID = saleID;
            SeatNum = seatNum;
            OriginalPrice = getOriginalPrice(seatNum);
            NewPrice = 0;
        }

        public string SaleID { get => _SaleID; set => _SaleID = value; }
        public int SeatNum { get => _SeatNum; set => _SeatNum = value; }
        public double OriginalPrice { get => _OriginalPrice; set => _OriginalPrice = value; }
        public double NewPrice { get => _NewPrice; set => _NewPrice = value; }

        //Adds a saleSeat record to the SaleSeats table
        public void addSaleSeat()
        {
            string sqlQuery = $"INSERT INTO SaleSeats (Sales_ID, Seat_Num, Ori_Price, New_Price) VALUES ('{this.SaleID}', {this.SeatNum}, {this.OriginalPrice}, {this.NewPrice})";

            cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        //Updates the NewPrice column for a chosen SeatType when its associated Price is updated
        public static void updateNewPrice(string seatType)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"UPDATE SaleSeats ss SET ss.New_Price = (SELECT st.Price FROM SeatTypes st WHERE st.Type_Code = '{seatType}') " +
                $"WHERE ss.Seat_Num IN(SELECT s.Seat_Num FROM Seats s WHERE s.Type_Code = '{seatType}')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        //Deletes saleSeats records from the SaleSeats table with the given saleID 
        public static void deleteSaleSeat(string saleID)
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"DELETE FROM SaleSeats WHERE Sales_ID = '{saleID}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        //Gets the original price from the Price column in the SeatTypes table
        private double getOriginalPrice(int seatNum)
        {
            string sqlQuery = $"SELECT st.Price FROM SeatTypes st JOIN Seats s ON st.Type_Code = s.Type_Code WHERE s.Seat_Num = {seatNum}";

            cmd = new OracleCommand(sqlQuery, conn);

            dr = cmd.ExecuteReader();

            if(dr.Read() && !dr.IsDBNull(0))
            {
                return Convert.ToDouble(dr.GetDouble(0).ToString("#.##"));
            }
            return 0;
        }
    }
}

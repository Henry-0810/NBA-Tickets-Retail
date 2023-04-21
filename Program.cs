using System;

using System.Windows.Forms;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace NBA_Tickets_Retail
{
    internal static class Program
    {
        private static OracleConnection conn;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //When system shuts down
            Application.ApplicationExit += new EventHandler(OnSysExit);
            //OracleConnection won't work the first time this project is clone, user need to go
            //Tools -> NuGet Packet Manager -> Manage NuGet Packages for Solutions -> click restore

            //const String oradb = "Data Source = oracle/orcl; User Id = T00229172; Password = fe4_Tdeegee6;";
            const String oradb = "Data Source = localhost/orcl; User Id = C##User; Password = itt12345;";
            conn = new OracleConnection(oradb);
            conn.Open();
            Console.WriteLine("Database Connection status is " + conn.State.ToString(), "Connection State");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainMenu());
          
        }

        //This is an event handle when system shutsdown, the database connection will be closed
        private static void OnSysExit(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }

        //A function to access database in other classes/forms
        public static OracleConnection getOracleConnection()
        {
            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ABC_Security_Company_InfoSys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        //connection string for database connection
        public static string connectionString()
        {
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ABC_Security_db.accdb;";
            return connection;
        }

    }
}

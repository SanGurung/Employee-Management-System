using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ABC_Security_Company_InfoSys
{
    class userAccount
    {
        private string userName;
        private string password;
        private string employeeID;

        public void setEmployeeID(string emp)
        {
            employeeID = emp;
        }
        public Boolean login(string user_name, string passwrd)
        {
            userName= user_name;
            password = passwrd;
            Boolean r = false;
            OleDbConnection connection = new OleDbConnection(Program.connectionString());
            string query;
            query = "SELECT count(*) FROM UserAccount where UserName='" + userName + "' AND Password='" + password + "'";

            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            command.CommandText = query;

            command.CommandType = CommandType.Text;
            int cnt=(Int32)command.ExecuteScalar();
            if ( cnt> 0)
            {
                r = true;
            }
            else
            {
                r = false;
            }
            connection.Close();
            return r;
        }
    }
}

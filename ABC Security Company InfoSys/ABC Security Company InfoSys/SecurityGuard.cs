using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ABC_Security_Company_InfoSys
{
    public class SecurityGuard : Employee
    {
        public void SecurityGuardDetails(string employee_ID, string employee_name, string employee_gender, string employee_dob, string employee_address, string employee_postCode, string employee_phoneNumber, string employee_doj, float securityGuard_hourlyRate)
        {
            savedetails(employee_ID,employee_name,employee_gender,employee_dob,employee_address,employee_postCode,employee_phoneNumber, employee_doj);

            this.hourlyRate = securityGuard_hourlyRate;
        }
        private float hourlyRate = 0;

        public float get_hourlyRate()
        {
            return this.hourlyRate;
        }
        public Boolean saveDetailsToDatabase()
        {
            savetodatabase();
            
            Boolean r = false;
            OleDbConnection connection = new OleDbConnection(Program.connectionString());
            string query;
            string ed = this.employeeID;
            query = "INSERT INTO SecurityGuard(EmployeeID,HourlyRate) VALUES ('" + ed+"',"+this.hourlyRate+")";
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            command.CommandText = query;

            command.CommandType = CommandType.Text;
            if (command.ExecuteNonQuery() > 0)
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

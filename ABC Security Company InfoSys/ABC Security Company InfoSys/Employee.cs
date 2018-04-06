using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ABC_Security_Company_InfoSys
{
    public class Employee
    {
        //Attributes
        protected string employeeID="";
        protected string name = "";
        protected string gender = "";
        protected string dob = "";
        protected string address = "";
        protected string postCode = "";
        protected string phoneNumber = "";
        protected string doj = "";
        //Functions started
        public string get_employeeID()
        {
            return this.employeeID;
        }
        public string get_name()
        {
            return this.name;
        }
        public string get_gender()
        {
            return this.gender;
        }
        public string get_dob()
        {
            return this.dob;
        }
        public string get_address()
        {
            return this.address;
        }
        public string get_postCode()
        {
            return this.postCode;
        }
        public string get_phoneNumber()
        {
            return this.phoneNumber;
        }
        public string get_doj()
        {
            return this.doj;
        }

        public void savedetails(string employee_ID, string employee_name, string employee_gender, string employee_dob, string employee_address, string employee_postCode, string employee_phoneNumber, string employee_doj)
         {
             this.employeeID = employee_ID;
             this.name = employee_name;
             this.gender = employee_gender;
             this.dob = employee_dob;
             this.address = employee_address;
             this.postCode = employee_postCode;
             this.phoneNumber= employee_phoneNumber;
             this.doj= employee_doj;
         }

        public Boolean savetodatabase()
        {
            Boolean r = false;
            OleDbConnection connection = new OleDbConnection(Program.connectionString());
            string query;
            query = "INSERT INTO Employee(EmployeeID,Name, Gender, dob, Address, PostCode, PhoneNumber, doj) VALUES ('" +this.employeeID+"','"+ this.name + "','" + this.gender + "','" + this.dob + "','" + this.address + "','" + this.postCode +"','"+ this.phoneNumber+"','"+this.doj+ "')";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ABC_Security_Company_InfoSys
{
    public class Attendance
    {
        private int attendanceID;
        private string employeeID;
        private int day_Deploy;
        private int month_Deploy;
        private int year_Deploy;
        private double workingHours;
        private double totalEarned;
        private float niDeduction;
        private float taxDeduction;

        public int get_AttendanceID(int attendance_ID)
        {
            return attendance_ID;
        }
        public string get_employeeID(string employee_ID)
        {
            return employee_ID;
        }
        public int get_dayDeploy(int dayDeploy)
        {
            return dayDeploy;
        }
        public int get_monthDeploy(int monthDeploy)
        {
            return monthDeploy;
        }
        public int get_yearDeploy(int yearDeploy)
        {
            return yearDeploy;
        }
        public double get_workingHours(double working_Hours)
        {
            return working_Hours;
        }
        public double get_totalEarned(double total_Earned)
        {
            return total_Earned;
        }
        public float get_niDeduction(float ni_Deduction)
        {
            return ni_Deduction;
        }
        public float get_taxDeduction(float tax_Deduction)
        {
            return tax_Deduction;
        }
        public Attendance(int attendance_ID, string employee_ID, int deploy_day, int deploy_month, int deploy_year, double working_Hours, double total_Earned, float ni_Deduction, float tax_Deduction)
        {
            this.attendanceID= attendance_ID;
            this.employeeID = employee_ID;
            this.day_Deploy = deploy_day;
            this.month_Deploy = deploy_month;
            this.year_Deploy = deploy_year;
            this.workingHours = working_Hours;
            this.totalEarned = total_Earned;
            this.niDeduction = ni_Deduction;
            this.taxDeduction = tax_Deduction;
        }

        public Boolean saveattendance()
        {
            Boolean r = false;
            OleDbConnection connection = new OleDbConnection(Program.connectionString());
            string query;
            query = "INSERT INTO Attendance (EmployeeID, Day_deploy, Month_deploy, Year_deploy, WorkingHours, TotalEarned, NiDeduction, TaxDeduction) VALUES ('" + this.employeeID + "'," + this.day_Deploy + "," + this.month_Deploy + "," + this.year_Deploy + "," + this.workingHours + "," + this.totalEarned + "," +this.niDeduction+","+this.taxDeduction+");";

            connection.Open();
            OleDbCommand Cmd = new OleDbCommand(query, connection);
            Cmd.CommandText = query;

            Cmd.CommandType = CommandType.Text;
            if (Cmd.ExecuteNonQuery() > 0)
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

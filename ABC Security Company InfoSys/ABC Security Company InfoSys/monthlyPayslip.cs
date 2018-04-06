using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABC_Security_Company_InfoSys
{
    public partial class monthlyPayslip : Form
    {
        public monthlyPayslip()
        {
            InitializeComponent();
        }

        private void monthlyPayslip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_Security_dbDataSet.Attendance' table. You can move, or remove it, as needed.
            //this.attendanceTableAdapter.Fill(this.aBC_Security_dbDataSet.Attendance);

        }

        private void show_Click(object sender, EventArgs e)
        {
            showSlip();
        }

        public void showSlip()
        {
            string query="";
            OleDbConnection connection = new OleDbConnection(Program.connectionString());
            query = "SELECT Employee.EmployeeID, Employee.Name, Employee.Gender,";
            query=query+"Attendance.Day_deploy, Attendance.Month_deploy, Attendance.Year_deploy,";
            query=query+"Attendance.WorkingHours, Attendance.NiDeduction, Attendance.TaxDeduction, Attendance.TotalEarned";
            query = query + " FROM Attendance INNER JOIN Employee ON Attendance.EmployeeID = Employee.EmployeeID";
            query = query + " WHERE Attendance.Month_deploy=" + int.Parse(this.compnt_month.Text) + " And  Attendance.Year_deploy=" + int.Parse(this.compnt_year.Text)+";";
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader;
            reader = command.ExecuteReader();
            double totalHours = 0,totalEarning = 0, totalNi = 0, totalTax = 0;
            while (reader.Read())
            {
                totalHours = totalHours + double.Parse(reader.GetValue(6).ToString());
                totalNi = totalNi + double.Parse(reader.GetValue(7).ToString());
                totalTax = totalTax + double.Parse(reader.GetValue(8).ToString());
                totalEarning = totalEarning + double.Parse(reader.GetValue(9).ToString());
            }
           
            reader.Close();
            this.compnt_hours.Text = "" + totalHours;
            this.compnt_Salary.Text = totalEarning.ToString();
            this.compnt_Tax.Text = totalTax.ToString();
            this.compnt_NI.Text = totalNi.ToString();
            connection.Close();
            OleDbDataAdapter dA = new OleDbDataAdapter(@query, connection);
            DataSet ds = new DataSet("dataGrid");
            dA.Fill(ds, "dataGrid");
            compnt_Grid.DataSource = ds.Tables[0];
            compnt_Grid.Update();
        }
    }
}

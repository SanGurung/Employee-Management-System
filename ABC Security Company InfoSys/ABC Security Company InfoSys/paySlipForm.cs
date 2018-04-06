using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ABC_Security_Company_InfoSys
{
    public partial class paySlipForm : Form
    {
        public paySlipForm()
        {
            InitializeComponent();
        }

        public void show()
        {
            double totalHours = 0, totalEarning = 0, totalNi = 0, totalTax = 0;
            string query = "";
            OleDbConnection connection = new OleDbConnection(Program.connectionString());
            int payslipMonth = int.Parse(this.compnt_month.Text);
            int payslipYear = int.Parse(this.compnt_year.Text);
            query = "SELECT * FROM Attendance WHERE EmployeeID='" + compnt_ID.Text + "' and month_Deploy=" + payslipMonth + " and year_Deploy=" + payslipYear + ";";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                totalHours = totalHours + double.Parse(rd.GetValue(5).ToString());
                totalEarning = totalEarning + double.Parse(rd.GetValue(6).ToString());
                totalNi = totalNi + double.Parse(rd.GetValue(7).ToString());
                totalTax = totalTax + double.Parse(rd.GetValue(8).ToString());
            }
            rd.Close();
            this.compnt_totalHWorkd.Text = "" + totalHours;
            this.compnt_Earned.Text = totalEarning.ToString();
            this.compnt_Tax.Text = totalTax.ToString();
            this.compnt_NI.Text = totalNi.ToString();
            connection.Close();
            OleDbDataAdapter dAdp = new OleDbDataAdapter(@query, connection);
            DataSet dset = new DataSet("dataGrid");
            dAdp.Fill(dset, "dataGrid");
            compnt_Grid.DataSource = dset.Tables[0];
            compnt_Grid.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void paySlipForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empdetaild.SecurityGuard' table. You can move, or remove it, as needed.
            this.securityGuardTableAdapter.Fill(this.empdetaild.SecurityGuard);
            // TODO: This line of code loads data into the 'aBC_Security_dbDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.aBC_Security_dbDataSet.Attendance);
            // TODO: This line of code loads data into the 'empdetaild.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empdetaild.Employee);

        }

        private void field_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }

        private void field_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_wage_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void compnt_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }

        private void compnt_guardName_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }
    }
}

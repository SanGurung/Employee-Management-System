using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABC_Security_Company_InfoSys
{
    public partial class attendanceForm : Form
    {
        public attendanceForm()
        {
            InitializeComponent();
        }

        private void attandanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empdetaild.SecurityGuard' table. You can move, or remove it, as needed.
            this.securityGuardTableAdapter.Fill(this.empdetaild.SecurityGuard);
            // TODO: This line of code loads data into the 'empdetaild.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empdetaild.Employee);
            Compnt_day.Text = "1";
            Compnt_month.Text = "1";
            Compnt_year.Text = "2009";
        }

        private void Compnt_calculate_Click(object sender, EventArgs e)
        {
            calculate_deduction();
        }

        public void calculate_deduction()
        {
            float ni = 0, tax = 0;
            float wHours = 0, defaultValue = 0;
            wHours = float.Parse("0" + Compnt_workingHours.Text);
            defaultValue = float.Parse("0" + Compnt_niPercentage.Text);
            ni = (wHours * defaultValue) / 100;
            Compnt_NI.Text = "" + ni;

            defaultValue = float.Parse("0" + Compnt_taxPercentage.Text);
            tax = (wHours * defaultValue) / 100;
            Compnt_tax.Text = "" + tax;
        }

        private void Compnt_saveCalculate_Click(object sender, EventArgs e)
        {
            float ni = 0, tax = 0;
            float wHours = 0, defaultValue = 0;
            wHours = float.Parse("0" + Compnt_workingHours.Text);
            defaultValue = float.Parse("0" + Compnt_niPercentage.Text);
            ni = (wHours * defaultValue) / 100;

            defaultValue = float.Parse("0" + Compnt_taxPercentage.Text);
            tax = (wHours * defaultValue) / 100;

            wHours = float.Parse("0" + Compnt_workingHours.Text);

            calculate_deduction();
            float totalEarned = 0;
            totalEarned = (wHours * float.Parse("0" + compnt_hourlyRate.Text))-(ni+tax);
            MessageBox.Show(" "+totalEarned);
            Attendance a = new Attendance(-1,compnt_employeeID.Text, int.Parse(Compnt_day.Text),int.Parse(Compnt_month.Text),int.Parse(Compnt_year.Text),double.Parse("0"+Compnt_workingHours.Text), totalEarned, ni,tax);
            if(a.saveattendance())
            {
                MessageBox.Show("Attendance has been taken.");
            }
            else
            {
                MessageBox.Show("Attendance wasnt taken!! Please try again.");
            }
        }
    }
}

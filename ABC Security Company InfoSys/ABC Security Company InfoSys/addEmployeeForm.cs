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
    public partial class addEmployeeForm : Form
    {
        public addEmployeeForm()
        {
            InitializeComponent();
        }

        private void field_clear_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void compnt__name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = easyFunctions.onlyLetters(e);
        }

        private void compnt__address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = easyFunctions.bothNumbersLetters(e);
        }

        private void compnt_postcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = easyFunctions.bothNumbersLetters(e);
        }

        private void compnt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = easyFunctions.bothNumbersLetters(e);
        }

        private void compnt_hourlyrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = easyFunctions.onlyNumbers(e);
        }

        private void compnt_Save_Click(object sender, EventArgs e)
        {
            DateTime d =DateTime.Now;
            string dt = d.ToShortDateString();
            SecurityGuard s = new SecurityGuard();
            s.SecurityGuardDetails(compnt__eid.Text, compnt__name.Text, compnt__gender.Text, compnt__dob.Text, compnt__address.Text, compnt_postcode.Text, compnt_phone.Text, dt, float.Parse(compnt_hourlyrate.Text));
            if (s.saveDetailsToDatabase())
            {
                MessageBox.Show("Employee Record has been added Successfully!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter valid data or user exist with similar details.");
            }
        }

        private void compnt_hourlyrate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

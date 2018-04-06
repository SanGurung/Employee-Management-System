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
    public partial class viewEmployeeDetailsForm : Form
    {
        public viewEmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void viewEmployeeDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empdetaild.SecurityGuard' table. You can move, or remove it, as needed.
            this.securityGuardTableAdapter.Fill(this.empdetaild.SecurityGuard);
          
            this.employeeTableAdapter.Fill(this.empdetaild.Employee);
            /*
            string sql;
            OleDbConnection conn = new OleDbConnection(Program.connectionString());
            conn.Open();
            sql = "SELECT * FROM Employee;";
            OleDbDataAdapter dA = new OleDbDataAdapter(@sql, conn);
            DataSet dset = new DataSet("DataSets");
            dA.Fill(dset, "DataSets");
            compt_dataGrid.DataSource = dset.Tables[0];
            compt_dataGrid.Update();
            */
        }

        private void field_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void field_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void compnt__phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void compt_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = easyFunctions.bothNumbersLetters(e);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! See you again.");
            Application.Exit();
        }

        private void logmein_Click(object sender, EventArgs e)
        {
            userAccount l=new userAccount();
            if (l.login(username.Text, password.Text))
            {
                MainInfoSysForm m = new MainInfoSysForm();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password incorrect, Try again.");
            }
        }
    }
}

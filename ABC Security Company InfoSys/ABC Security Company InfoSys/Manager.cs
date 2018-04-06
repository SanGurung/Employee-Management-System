using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Class jus for clearance of securityGuard as an inheritance
namespace ABC_Security_Company_InfoSys
{
    public class Manager : Employee
    {
        private double monthlySalary = 0;
        public double get_monthlySalary()
        {
            return this.monthlySalary;
        }
    }
}

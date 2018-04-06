using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABC_Security_Company_InfoSys
{
    static class easyFunctions
    {
        public static Boolean onlyNumbers(KeyPressEventArgs e)
        {
            if (((char.IsNumber(e.KeyChar) || (Keys)e.KeyChar == Keys.Back)))
            {
                return false;
            }
            return true;
        }

        public static Boolean onlyLetters(KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar) || (Keys)e.KeyChar == Keys.Back) || ((Keys)e.KeyChar == Keys.Decimal) || ((Keys)e.KeyChar == Keys.Space))
            {
                return false;
            }
            return true;
        }

        public static Boolean bothNumbersLetters(KeyPressEventArgs e)
        {
            if ((onlyLetters(e) == false || onlyNumbers(e) == false))
            {
                return false;
            }
            return true;
        }
    }
}

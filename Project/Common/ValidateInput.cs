using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class ValidateInput
    {
        // empty or null text
        public static bool isEmpty(Control control)
        {
            return String.IsNullOrEmpty(control.Text);
        }

        // word characters and number characters
        public static bool isAlphanumeric(Control control)
        {
            return Regex.IsMatch(control.Text, "^[a-zA-Z0-9]+$");
        }

        // password length requires greater than 6 characters
        public static bool isPassword(Control control)
        {
            return control.Text.Length >= 6;
        }

        public static bool isUnicode(Control control)
        {
            return Regex.IsMatch(control.Text, @"^[\p{L} ]+$");
        }

        public static bool isNumber(Control control)
        {
            return Regex.IsMatch(control.Text, @"^\d+$");
        }
    }
}

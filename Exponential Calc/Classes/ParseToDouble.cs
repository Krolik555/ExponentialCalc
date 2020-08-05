using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Calc.Classes
{
    class ParseToDouble
    {
        public static double USD(TextBox textbox)
        {
            try
            {
                return double.Parse(textbox.Text, NumberStyles.Currency);
            }
            catch (FormatException)
            {
                if (textbox.Text == "")
                {
                    return 0;
                }
                else
                {
                    return double.Parse(textbox.Text);
                }
                
            }
        }

        public static double NotUSD(TextBox textbox)
        {
            try
            {
                return double.Parse(textbox.Text);
            }
            catch (FormatException)
            {
                if (textbox.Text == "")
                {
                    return 0;
                }
                else
                {
                    return double.Parse(textbox.Text);
                }

            }
        }
    }
}

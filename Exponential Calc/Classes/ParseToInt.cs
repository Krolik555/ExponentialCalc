using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Calc.Classes
{
    class ParseToInt
    {
        public static double Run(TextBox textbox)
        {
            if (textbox.Text != "")
            {
                return ParseToDouble.NotUSD(textbox);
            }
            else
            {
                return 0;
            }
        }
    }
}

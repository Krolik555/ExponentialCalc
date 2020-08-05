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
        public static int Run(TextBox textbox)
        {
            if (textbox.Text != "")
            {
                return Convert.ToInt32(textbox.Text);
            }
            else
            {
                return 0;
            }
        }
    }
}

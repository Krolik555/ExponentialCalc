using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Calc.Classes
{
    class Textbox_to_USD
    {
        public static void convert (TextBox textbox)
        {
            Double value;
            if (Double.TryParse(textbox.Text, out value))
                textbox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                textbox.Text = String.Empty;
        }
    }
}

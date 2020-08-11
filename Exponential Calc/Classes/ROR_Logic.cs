using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Calc.Classes
{
    class ROR_Logic
    {
        /// <summary>
        /// Determines if TTL is Days, Months or Years and adjusts the Yearly ROR accordingly
        /// </summary>
        /// <param name="Compound"></param>
        /// <param name="ROR"></param>
        /// <returns></returns>
        public static double TimespanLogic(ComboBox RunFor_Type, double ROR)
        {
            double CalculatedROR = 0.0;

            try
            {
                CalculatedROR = ROR / 365;
                //if (RunFor_Type.SelectedItem.ToString() == "Days")
                //{
                //    CalculatedROR = ROR / 365;
                //}
                //else if (RunFor_Type.SelectedItem.ToString() == "Months")
                //{
                //    CalculatedROR = ROR / 12;
                //}
                //else if (RunFor_Type.SelectedItem.ToString() == "Years")
                //{
                //    CalculatedROR = ROR;
                //}
            }
            catch
            {

            }

            return CalculatedROR;
        }

    }
}

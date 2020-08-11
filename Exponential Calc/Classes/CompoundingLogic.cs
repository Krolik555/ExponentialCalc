using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Calc.Classes
{
    class CompoundingLogic
    {
        public static double Compound(ComboBox runFor, int T, double calculatedROR, double Results, double TTL)
        {
            double compoundedresults = 0.0;

            #region Compound Daily
            if (runFor.SelectedItem.ToString() == "Days")
            {
                compoundedresults = Results * (calculatedROR + 1); // results X CalculatedROR (Ex. 
            }
            if (runFor.SelectedItem.ToString() == "Months")
            {
                compoundedresults = Results;
                for (int i = 1; i <= 30; i++)
                {
                    compoundedresults = compoundedresults * (calculatedROR + 1); // results X CalculatedROR (Ex. 
                }
            }
            if (runFor.SelectedItem.ToString() == "Years")
            {
                compoundedresults = Results;
                for (int i = 1; i <= 365; i++)
                {
                    compoundedresults = compoundedresults * (calculatedROR + 1); // results X CalculatedROR (Ex. 
                }
            }
            #endregion Compound Daily


            return compoundedresults;
        }
    }
}

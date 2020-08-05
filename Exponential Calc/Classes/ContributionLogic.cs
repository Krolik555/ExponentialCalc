using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Calc.Classes
{
    class ContributionLogic
    {
        public static double Run(ComboBox TTL_Type, ComboBox Contribution_Type, double Contribution, int TimeSpan)
        {
            double _results = 0;

            if (TTL_Type.SelectedItem.ToString() == "Years") // If 'Run for' is set to 'Years'
            {
                if (Contribution_Type.SelectedItem.ToString() == "Yearly") // If contribution is set to Yearly
                {
                    _results += Contribution;
                }
                else if (Contribution_Type.SelectedItem.ToString() == "Monthly")// If contribution is set to Monthly
                {
                    double ContXtwelve = Contribution * 12;
                    _results += ContXtwelve;
                }
                else if (Contribution_Type.SelectedItem.ToString() == "Daily")// If contribution is set to Daily
                {
                    double ContXThreeSixFive = Contribution * 365;
                    _results += ContXThreeSixFive;
                }
            }
            else if (TTL_Type.SelectedItem.ToString() == "Months") // If 'Run for' is set to 'Months'
            {
                if (Contribution_Type.SelectedItem.ToString() == "Yearly" && TimeSpan % 12 == 0 && TimeSpan >= 12) // If contribution is set to Yearly
                {
                    _results += Contribution;
                }
                else if (Contribution_Type.SelectedItem.ToString() == "Monthly")// If contribution is set to Monthly
                {
                    _results += Contribution;
                }
                else if (Contribution_Type.SelectedItem.ToString() == "Daily")// If contribution is set to Daily
                {
                    double ContXThreeSixFive = Contribution * 30;
                    _results += ContXThreeSixFive;
                }
            }
            else if (TTL_Type.SelectedItem.ToString() == "Days") // If 'Run for' is set to 'Days'
            {
                if (Contribution_Type.SelectedItem.ToString() == "Yearly" && TimeSpan % 365 == 0 && TimeSpan >= 365) // If contribution is set to Yearly
                {
                    _results += Contribution;
                }
                else if (Contribution_Type.SelectedItem.ToString() == "Monthly" && TimeSpan % 30 == 0 && TimeSpan >= 30)// If contribution is set to Monthly
                {
                    _results += Contribution;
                }
                else if (Contribution_Type.SelectedItem.ToString() == "Daily")// If contribution is set to Daily
                {
                    _results += Contribution;
                }
            }

            return _results;
        }
    }
}

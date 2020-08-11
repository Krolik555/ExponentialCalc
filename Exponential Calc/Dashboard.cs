using Exponential_Calc.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Calc
{
    public partial class Dashboard : Form
    {
        public static List<double> ReturnedValues = new List<double>();

        public Dashboard()
        {
            InitializeComponent();

            aComboboxCompound.SelectedIndex = 2;
            aComboboxContribution_Type.SelectedIndex = 1;
            aComboBoxTTL_Type.SelectedIndex = 0;
        }

        private void aButtonSubmit_Click(object sender, EventArgs e)
        {
            double RateofReturn = ParseToDouble.NotUSD(aTextBoxRateOfReturn) / 100;
            // convert TTL Textbox to int
            double TTL = ParseToDouble.NotUSD(aTextBoxTTL);

            double StartingValue = Classes.ParseToDouble.USD(aTextBoxStartingValue);
            double Contribution = Classes.ParseToDouble.USD(aTextBoxContribution);
            double Results = StartingValue; // Will be used to display the results. It must start with the starting value.

            //calculatedRO is the RateofReturn adjusted for the TTL_Type
            double calculatedROR = ROR_Logic.TimespanLogic(aComboBoxTTL_Type, RateofReturn);

            for (int T = 1; T <= TTL; T++)
            {
                // Calculate
                Results = CompoundingLogic.Compound(aComboBoxTTL_Type, T, calculatedROR, Results, TTL);
                //Results = Results * (calculatedROR + 1); // results X CalculatedROR (Ex. 

                // Add contribution
                Results += ContributionLogic.Run(aComboBoxTTL_Type, aComboboxContribution_Type, Contribution, T);
            }
            aTextBoxResults.Text = Results.ToString();
            aTextBoxResults.Text = (ParseToDouble.USD(aTextBoxResults).ToString("C2"));
        }

        private void aTextBoxStartingValue_Leave(object sender, EventArgs e)
        {
            aTextBoxStartingValue.Text = (ParseToDouble.USD(aTextBoxStartingValue).ToString("C2"));


        }

        private void aTextBoxContribution_Leave(object sender, EventArgs e)
        {
            aTextBoxContribution.Text = (ParseToDouble.USD(aTextBoxContribution).ToString("C2"));
        }

        private void aTextBoxTTL_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if Backspace pressed
            if(e.KeyChar != '\b')
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }
            
        }
    }
}

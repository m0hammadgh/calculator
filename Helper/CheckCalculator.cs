using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Helper
{
    public static class CheckCalculator
    {
        public static bool IsCalculatorOn(this bool state,TextBox textBox)
        {
            if (state)
            {
                return true;
            }
            else
            {
                textBox.Text = "";
                return false;
            }
        }
    }
}

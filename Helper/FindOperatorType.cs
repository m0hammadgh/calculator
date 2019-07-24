using Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Helper
{
    static class  FindOperatorType
    {
        public static Operators GetOperatorNameBySign(this string text)
        {
            if (text.Contains("+"))
            {
                return Operators.Plus;

            }
            else if (text.Contains("-"))
            {
                return Operators.Minus;

            }
            else if (text.Contains("/"))
            {
                return Operators.Divide;

            }
            else if (text.Contains("*"))
            {
                return Operators.Multiple;

            }
            return Operators.None;
        }
    }
}

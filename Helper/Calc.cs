using Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Helper
{
    class Calc
    {

        public static object Calculate(Int64 num1, Int64 num2, Operators operand)
        {
            switch (operand)
            {
                case Operators.None:
                    return 0;
                case Operators.Plus:
                    return (num1 + num2);
                case Operators.Minus:
                    return (num1 - num2);
                case Operators.Multiple:
                    return (num1 * num2);
                case Operators.Divide:
                    return (double)num1 / num2;
                default:
                    return 0;
            }
        }
    }
}

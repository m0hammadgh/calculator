using Calculator.Enums;
using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Helper
{
    class Calc
    {  public static object Calculate(CalcModel calc)
        {
            switch (calc.Oprator)
            {
                case Operators.None:
                    return 0;
                case Operators.Plus:
                    return (calc.Num1 + calc.Num2);
                case Operators.Minus:
                    return (calc.Num1 - calc.Num2);
                case Operators.Multiple:
                    return (calc.Num1 * calc.Num2);
                case Operators.Divide:
                    return (double)calc.Num1 / calc.Num2;
                default:
                    return 0;
            }
        }
    }
}

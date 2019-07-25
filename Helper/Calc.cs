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
    {  public static CalcModel Calculate(CalcModel calc)
        {
            switch (calc.Oprator)
            {
                case Operators.None:
                    return calc;
                case Operators.Plus:
                    calc.Result += calc.Num2;
                    calc.Num1 = calc.Num2;
                    return calc;
                case Operators.Minus:
                    calc.Result -= calc.Num2;
                    calc.Num1 = calc.Num2;
                    return calc;
                case Operators.Multiple:
                    calc.Result *= calc.Num2;
                    calc.Num1 = calc.Num2;
                    return calc;
                case Operators.Divide:
                    calc.Result /= calc.Num2;
                    calc.Num1 = calc.Num2;
                    return calc;
                default:
                    return calc;
            }
        }
    }
}

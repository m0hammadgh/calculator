using Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Extensions
{
    public static class TextExtensions
    {

        public static string GetOperatorSignByName(this Operators operators)
        {
            switch (operators)
            {
                case Operators.None:
                    return "";
                case Operators.Plus:
                    return "+";
                case Operators.Minus:
                    return "-";
                case Operators.Multiple:
                    return "*";
                case Operators.Divide:
                    return "/";
                default:
                    return "";
            }
        } // Extension Method for Operators Enum
    }
}

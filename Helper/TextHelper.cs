using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Calculator.Enums;
using Calculator.Extensions;
using Calculator.Model;

namespace Calculator.Helper
{
    public class TextHelper
    {

        public static string ClearLastNumber(String text) => text.Remove(text.Length - 1); //lol  :P Extension method to clear the last char of a text


        public static string ChangeOperator(string text, Operators operand)   //:P :D  Replace the desired operand in the given text
        {
            switch (FindOperatorType.GetOperatorNameBySign(text))
            {

                case Operators.None:
                    return text + operand.GetOperatorSignByName();
                case Operators.Plus:
                    return (SplitText(text, '+')[0] + operand.GetOperatorSignByName() + SplitText(text, '+')[1]);
                case Operators.Minus:
                    return (SplitText(text, '-')[0] + operand.GetOperatorSignByName() + SplitText(text, '-')[1]);
                case Operators.Multiple:
                    return (SplitText(text, '*')[0] + operand.GetOperatorSignByName() + SplitText(text, '*')[1]);
                case Operators.Divide:
                    return (SplitText(text, '/')[0] + operand.GetOperatorSignByName() + SplitText(text, '/')[1]);
                default:
                    return text + operand.GetOperatorSignByName();
            }
        }

        public static string[] SplitText(string text, char regex)
        {
            return text.Split(regex);
        }

        public static string[] SplitText(string text, Operators operand)
        {
            switch (operand)
            {
                case Operators.None:
                    return text.Split();
                case Operators.Plus:
                    return text.Split('+');
                case Operators.Minus:
                    return text.Split('-');
                case Operators.Multiple:
                    return text.Split('*');
                case Operators.Divide:
                    return text.Split('/');
                default:
                    return text.Split();
            }

        }

        public static CalcModel SetCalcValues(double number1,Operators operand)
        {
            return new CalcModel {
                Num1=number1,
                Oprator=operand
            };
        }
    }
}

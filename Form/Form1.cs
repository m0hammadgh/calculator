using Calculator.Enums;
using Calculator.Extensions;
using Calculator.Helper;
using Calculator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool isOn = false;
        private bool isFirst = false;
        private CalcModel calculateObject = new CalcModel();
        private string lastOperand="";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (edtOperation.Text.Length > 0)
            {
                edtOperation.Text = TextHelper.ClearLastNumber(edtOperation.Text);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            edtOperation.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            edtOperation.Enabled = false;

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (isOn && edtOperation.Text != "")
            {
                lastOperand = "/";
                if (calculateObject.Oprator==Operators.None)
                {
                    calculateObject.Oprator = Operators.Divide;
                }
                btnResult.PerformClick();
                calculateObject.Oprator = Operators.Divide;
                
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            lastOperand = "*";
            if (isOn && edtOperation.Text != "")
            {
                if (calculateObject.Oprator == Operators.None)
                {
                    calculateObject.Oprator = Operators.Multiple;
                }
                btnResult.PerformClick();
                calculateObject.Oprator = Operators.Multiple;
                
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lastOperand = "-";
            if (isOn && edtOperation.Text != "")
            {
                if (calculateObject.Oprator == Operators.None)
                {
                    calculateObject.Oprator = Operators.Minus;
                }
                btnResult.PerformClick();
                calculateObject.Oprator = Operators.Minus;
               
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lastOperand = "+";
            if (isOn && edtOperation.Text != "")
            {
                if (calculateObject.Oprator == Operators.None)
                {
                    calculateObject.Oprator = Operators.Plus;
                }
                btnResult.PerformClick();
                calculateObject.Oprator = Operators.Plus;
               

            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            try
            {
                if (calculateObject.Oprator == Operators.None)
                {
                    MessageBox.Show("عملگر را انتخاب کنید");
                }
                else
                {

                    calculateObject.Num2 = double.Parse(edtOperation.Text);
                    edtOperation.Text = "";
                    tvCurrentOperation.Text += calculateObject.Num2 + lastOperand;
                    tvResult.Text = Calc.Calculate(calculateObject).Result.ToString();

                }
            }
            catch (Exception)
            {

                tvResult.Text = "Error";
            }

        }

        private void edtOperation_TextChanged(object sender, EventArgs e)
        {
            isOn.IsCalculatorOn(edtOperation);
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            edtOperation.Enabled = true;
            isOn = true;
        }
        private void SetText(String number)
        {

            edtOperation.Text = edtOperation.Text + number;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                calculateObject.Oprator = Operators.None;
                edtOperation.Text = calculateObject.Num1.ToString();
                return true;
            }
            else if (keyData == (Keys.Add))
            {
                btnPlus.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Subtract))
            {
                btnMinus.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Divide))
            {
                btnDivide.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Multiply))
            {
                btnMultiple.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
    }




}

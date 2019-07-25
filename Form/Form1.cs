using Calculator.Enums;
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
        private CalcModel calculateObject = new CalcModel();
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
            if (isOn)
            {
                calculateObject = TextHelper.SetCalcValues(double.Parse(edtOperation.Text), Operators.Divide);
                edtOperation.Text = "";
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                calculateObject = TextHelper.SetCalcValues(double.Parse(edtOperation.Text), Operators.Multiple);
                edtOperation.Text = "";
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                calculateObject = TextHelper.SetCalcValues(double.Parse(edtOperation.Text), Operators.Minus);
                edtOperation.Text = "";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                calculateObject = TextHelper.SetCalcValues(double.Parse(edtOperation.Text), Operators.Plus);
                edtOperation.Text = "";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            try
            {
                if (calculateObject.Oprator == Operators.None)
                {
                    MessageBox.Show("عملگر را انمتخاب کنید");
                }
                else
                {
                    calculateObject.Num2 = double.Parse(edtOperation.Text);
                    tvResult.Text = Calc.Calculate(calculateObject).ToString();

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

        private void btn1_Click(object sender, EventArgs e)
        {
            SetText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SetText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SetText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            SetText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SetText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SetText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SetText("7");
        }


        private void button8_Click(object sender, EventArgs e)
        {
            SetText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SetText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            SetText("0");
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
            else if(keyData == (Keys.Multiply))
            {
                btnMultiple.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }


}

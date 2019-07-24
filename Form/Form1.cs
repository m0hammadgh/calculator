using Calculator.Enums;
using Calculator.Helper;
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


        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            edtOperation.Text = TextHelper.ChangeOperator(edtOperation.Text, Operators.Divide);
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            edtOperation.Text = TextHelper.ChangeOperator(edtOperation.Text, Operators.Multiple);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            edtOperation.Text = TextHelper.ChangeOperator(edtOperation.Text, Operators.Minus);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            edtOperation.Text = TextHelper.ChangeOperator(edtOperation.Text, Operators.Plus);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Operators operand = edtOperation.Text.GetOperatorNameBySign();
            try
            {
                tvResult.Text = Calc.Calculate(Int64.Parse(TextHelper.SplitText(edtOperation.Text, operand)[0]),
                           Int64.Parse(TextHelper.SplitText(edtOperation.Text, operand)[1]),
                           operand).ToString();
            }
            catch (Exception)
            {

                tvResult.Text = "Error";
            }
           
        }
    }


}

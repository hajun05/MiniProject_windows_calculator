using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_windows_calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            RHS_Output.Text = "0";
        }

        // %버튼
        private void Modulo_Click(object sender, EventArgs e)
        {
            UnaryOperations unaryOperations = new UnaryOperations();
            //현재 값 검사 후 숫자가 있으면 가져와서 % 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string result = unaryOperations.Percent(RHS_Output.Text);
                RHS_Output.Text = result;
            }
            //값이 없다면 아무 실행 X
        }

        //분수 버튼(1/x)
        private void Fraction_Click(object sender, EventArgs e)
        {
            UnaryOperations unaryOperations = new UnaryOperations();
            //현재 값 검사 후 숫자가 있으면 가져와서 분수 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string result = unaryOperations.Fraction(RHS_Output.Text);
                RHS_Output.Text = result;
            }
            //값이 없다면 아무 실행 X
        }

        //제곱 버튼 x^2
        private void SQR_Click(object sender, EventArgs e)
        {
            UnaryOperations unaryOperations = new UnaryOperations();
            //현재 값 검사 후 숫자가 있으면 가져와서 제곱 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string result = unaryOperations.Square(RHS_Output.Text);
                RHS_Output.Text = result;
            }
            //값이 없다면 아무 실행 X
        }

        //제곱근 버튼 
        private void SquareRoot_Click(object sender, EventArgs e)
        {
            UnaryOperations unaryOperations = new UnaryOperations();
            //현재 값 검사 후 숫자가 있으면 가져와서 제곱근 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string result = unaryOperations.Root(RHS_Output.Text);
                RHS_Output.Text = result;
            }
            //값이 없다면 아무 실행 X
        }

        //소수점 버튼
        private void DecimalPoint_Click(object sender, EventArgs e)
        {
            AdditionalFunction additionalFunction = new AdditionalFunction();
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string result = additionalFunction.DecimalPoint(RHS_Output.Text);
                RHS_Output.Text = result;
            }

        }

        //음수양수로 바꾸기
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            UnaryOperations unaryOperations = new UnaryOperations();
            //현재 값 검사 후 숫자가 있으면 가져와서 음수양수 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string result = unaryOperations.NegativePositive(RHS_Output.Text);
                RHS_Output.Text = result;
            }
            //값이 없다면 아무 실행 X
        }
    }
}


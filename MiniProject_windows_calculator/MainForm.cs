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
        //클래스 인스턴스 생성
        ClearFunction clearFunction = new ClearFunction(); //전역변수 초기화용
        UnaryOperations unaryOperations = new UnaryOperations();
        AdditionalFunction additionalFunction = new AdditionalFunction();
        NumberButtons numberButtons = new NumberButtons();

        //변수
        string recentlyInput; // 숫자면 num, 연산자면 oper

        public Calculator()
        {
            InitializeComponent();
            RHS_Output.Text = "0";
        }

        // %버튼
        private void Modulo_Click(object sender, EventArgs e)
        {
            //현재 값 검사 후 숫자가 있으면 가져와서 % 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string[] result = new string[2];
                result = unaryOperations.Percent(RHS_Output.Text, LHS_Output.Text);
                RHS_Output.Text = result[0];
                LHS_Output.Text = result[1];
            }
            //값이 없다면 아무 실행 X
        }

        //분수 버튼(1/x)
        private void Fraction_Click(object sender, EventArgs e)
        {
            //현재 값 검사 후 숫자가 있으면 가져와서 분수 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string[] result = unaryOperations.Fraction(RHS_Output.Text, LHS_Output.Text);
                RHS_Output.Text = result[0];
                LHS_Output.Text = result[1];
            }
            //값이 없다면 아무 실행 X
        }

        //제곱 버튼 x^2
        private void SQR_Click(object sender, EventArgs e)
        {
            //현재 값 검사 후 숫자가 있으면 가져와서 제곱 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string[] result = unaryOperations.Square(RHS_Output.Text, LHS_Output.Text);
                RHS_Output.Text = result[0];
                LHS_Output.Text = result[1];
            }
            //값이 없다면 아무 실행 X
        }

        //제곱근 버튼 
        private void SquareRoot_Click(object sender, EventArgs e)
        {
            //현재 값 검사 후 숫자가 있으면 가져와서 제곱근 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string[] result = unaryOperations.Root(RHS_Output.Text, LHS_Output.Text);
                RHS_Output.Text = result[0];
                LHS_Output.Text = result[1];
            }
            //값이 없다면 아무 실행 X
        }

        //소수점 버튼
        private void DecimalPoint_Click(object sender, EventArgs e)
        {
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string result = additionalFunction.DecimalPoint(RHS_Output.Text);
                RHS_Output.Text = result;
            }
        }

        //음수양수로 바꾸기
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            //현재 값 검사 후 숫자가 있으면 가져와서 음수양수 함수 실행
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                string result = unaryOperations.NegativePositive(RHS_Output.Text);
                RHS_Output.Text = result;
            }
            //값이 없다면 아무 실행 X
        }

        //CE 버튼 (최근항목 삭제)
        private void CE_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = "0";
        }

        //C 버튼 (전체 삭제)
        private void C_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = "0";
            LHS_Output.Text = "";
        }

        // 백스페이스 버튼
        private void Delete_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = RHS_Output.Text.Remove(RHS_Output.Text.Length - 1);
            if (RHS_Output.Text.Length == 0) RHS_Output.Text = "0";
        }

        //숫자 0 버튼
        private void Zero_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.ZeroButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        // 숫자 1 버튼
        private void One_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.OneButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        //숫자 2버튼
        private void Two_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.TwoButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        // 숫자 3버튼
        private void Three_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.ThreeButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        //숫자 4버튼
        private void Four_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.FourButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        // 숫자 5버튼
        private void Five_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.FiveButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        // 숫자 6버튼
        private void Six_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.SixButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        // 숫자 7버튼
        private void Seven_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.SevenButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        // 숫자 8버튼
        private void Eight_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.EightButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }

        //숫자 9버튼
        private void Nine_Click(object sender, EventArgs e)
        {
            RHS_Output.Text = numberButtons.NineButton(RHS_Output.Text, LHS_Output.Text, recentlyInput);
            recentlyInput = "num";
        }
    }
}
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

        private char past_operator = '='; // 이전 연산자 확인에 사용

        // 나누기 버튼
        private void Division_Click(object sender, EventArgs e)
        {
            // 피연산자 값(숫자)을 입력하지 않았거나 오류로 값이 사라진 상황에선 연산 실행 생략
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                ElementaryArithmetic elementaryArithmetic = new ElementaryArithmetic();

                // 수식에 추가할 항(수식 + 피연산자 연산자)
                string add_term = elementaryArithmetic.division(RHS_Output.Text);
                // 이전에 = 연산자를 입력했으면 = 좌항 정리
                if (LHS_Output.Text.Length > 1 && LHS_Output.Text.Substring(LHS_Output.Text.Length - 1) == "=")
                {
                    LHS_Output.Text = add_term;
                }
                else
                {
                    LHS_Output.Text += add_term;
                }
            }
        }
        
        // 곱하기 버튼
        private void Multiplication_Click(object sender, EventArgs e)
        {
            // 피연산자 값(숫자)을 입력하지 않았거나 오류로 값이 사라진 상황에선 연산 실행 생략
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                ElementaryArithmetic elementaryArithmetic = new ElementaryArithmetic();

                // 수식에 추가할 항(수식 + 피연산자 연산자)
                string add_term = elementaryArithmetic.multiplication(RHS_Output.Text);
                // 이전에 = 연산자를 입력했으면 = 좌항 정리
                if (LHS_Output.Text.Length > 1 && LHS_Output.Text.Substring(LHS_Output.Text.Length - 1) == "=")
                {
                    LHS_Output.Text = add_term;
                }
                else
                {
                    LHS_Output.Text += add_term;
                }
            }
        }
        
        // 빼기 버튼
        private void Subtraction_Click(object sender, EventArgs e)
        {
            // 피연산자 값(숫자)을 입력하지 않았거나 오류로 값이 사라진 상황에선 연산 실행 생략
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                ElementaryArithmetic elementaryArithmetic = new ElementaryArithmetic();

                // 수식에 추가할 항(수식 + 피연산자 연산자)
                string add_term = elementaryArithmetic.subtraction(RHS_Output.Text);
                // 이전에 = 연산자를 입력했으면 = 좌항 정리
                if (LHS_Output.Text.Length > 1 && LHS_Output.Text.Substring(LHS_Output.Text.Length - 1) == "=")
                {
                    LHS_Output.Text = add_term;
                }
                else
                {
                    LHS_Output.Text += add_term;
                }
            }
        }

        // 더하기 버튼
        private void Addition_Click(object sender, EventArgs e)
        {
            // 피연산자 값(숫자)을 입력하지 않았거나 오류로 값이 사라진 상황에선 연산 실행 생략
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                ElementaryArithmetic elementaryArithmetic = new ElementaryArithmetic();

                // 수식에 추가할 항(수식 + 피연산자 연산자)
                string add_term = elementaryArithmetic.addition(RHS_Output.Text);
                // 이전에 = 연산자를 입력했으면 = 좌항 정리
                if (LHS_Output.Text.Length > 1 && LHS_Output.Text.Substring(LHS_Output.Text.Length - 1) == "=") 
                {
                    LHS_Output.Text = add_term;
                }
                else
                { 
                    LHS_Output.Text += add_term; 
                }
            }
        }

        // = 버튼. 수식의 계산값 출력
        private void Assignment_Click(object sender, EventArgs e)
        {
            // 피연산자 값(숫자)을 입력하지 않았거나 오류로 값이 사라진 상황에선 연산 실행 생략
            if (RHS_Output.Text != "" && RHS_Output.Text != "0으로 나눌 수 없습니다.")
            {
                ElementaryArithmetic elementaryArithmetic = new ElementaryArithmetic();

                string result = elementaryArithmetic.assignment(LHS_Output.Text, RHS_Output.Text);
                LHS_Output.Text += RHS_Output.Text + " = ";
                RHS_Output.Text = result;
            }
        }

        // LHS_Output창에 직접 입력(커서) 방지
        private void LHS_Output_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }

        // RHS_Output창에 숫자, 백스페이스, 소수점 이외 직접 입력(커서) 방지
        private void RHS_Output_KeyPress(object sender, KeyPressEventArgs e)
        {
            // RHS 출력값이 "0"(아무것도 입력 X)한 상태일 때 공백으로 수정. 0이 맨 앞으로 가는 상황 방지
            if (RHS_Output.Text == "0")
            {
                RHS_Output.Text = "";
            }
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))
            {
                e.Handled = true; 
            }
        }

        private void RHS_Output_Enter(object sender, EventArgs e)
        {
            // RHS 출력값이 ""(모든 입력값 삭제)한 상태일 때 "0"으로 수정. RHS 출력값이 완전히 비는 상황 방지
            if (RHS_Output.Text == "")
            {
                RHS_Output.Text = "0";
            }
            // 커서가 항상 오른쪽 끝에 위치하도록 고정
            RHS_Output.SelectionStart = RHS_Output.Text.Length;
        }
    }
}


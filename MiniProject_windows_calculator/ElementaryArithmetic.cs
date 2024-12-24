using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_windows_calculator
{
    internal class ElementaryArithmetic
    {
        // 나누기 버튼
        public string division(string operand)
        {
            return (operand + " ÷ "); // 수식에 추가할 항 반환
        }

        // 곱하기 버튼
        public string multiplication(string operand)
        {
            return (operand + " × "); // 수식에 추가할 항 반환
        }

        // 빼기 버튼
        public string subtraction(string operand)
        {
            return (operand + " − "); // 수식에 추가할 항 반환
        }

        // 더하기 버튼
        public string addition(string operand)
        {
            return (operand + " + "); // 수식에 추가할 항 반환
        }

        // = 버튼
        public string assignment(string expression, string operand_add)
        {
            string[] expression_terms = expression.Split(' ');
            double result = 0.0;
            if (double.TryParse(expression_terms[0], out result))
            {
                double operand_num = 0;
                for (int i = 2; i < expression_terms.Length - 2; i += 2)
                {
                    double.TryParse(expression_terms[i], out operand_num);
                    switch (expression_terms[i - 1])
                    {
                        case "÷":
                            if (operand_num == 0)
                                return "0으로 나눌 수 없습니다.";
                            result /= operand_num;
                            break;
                        case "×":
                            result *= operand_num;
                            break;
                        case "−":
                            result -= operand_num;
                            break;
                        case "+":
                            result += operand_num;
                            break;
                    }
                }
            }
            else
            {
                result = double.Parse(operand_add);
            }

            return result.ToString(); // 수식에 추가할 항 반환
        }
    }
}

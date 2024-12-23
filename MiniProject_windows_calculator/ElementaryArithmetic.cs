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
            return (operand + " ÷"); // 수식에 추가할 항 반환
        }

        // 곱하기 버튼
        public string multiplication(string operand)
        {
            return (operand + " ×"); // 수식에 추가할 항 반환
        }

        // 빼기 버튼
        public string subtraction(string operand)
        {
            return (operand + " −"); // 수식에 추가할 항 반환
        }

        // 더하기 버튼
        public string addition(string operand)
        {
            return (operand + " +"); // 수식에 추가할 항 반환
        }

        // = 버튼
        public string assignment(string operand)
        {
            return ""; // 수식에 추가할 항 반환
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_windows_calculator
{
    internal class UnaryOperations
    {
        // %버튼
        public string Percent(string input)
        {
            double input_d = double.Parse(input);
            if (input_d == 0)
            {
                return '0'.ToString();
            }
            else
            {
                double result = input_d / 100;
                return result.ToString();
            }
        }

        // 제곱 버튼 x^2
        public string Square(string input)
        {
            double input_d = double.Parse(input);
            double result = Math.Pow(input_d, 2);
            return result.ToString();

        }

        // 제곱근(루트) 버튼
        public string Root(string input)
        {
            double input_d = double.Parse(input);
            double result = Math.Sqrt(input_d);
            return result.ToString();
        }

        // 분수 만들기 1/x
        public string Fraction(string input)
        {
            double input_d = double.Parse(input);
            if (input_d == 0)
            {
                return "0으로 나눌 수 없습니다.";
            }
            else
            {
                double result = 1 / input_d;
                return result.ToString();
            }
        }

        // 음수, 양수 바꾸기
        // +/- 버튼
        public string NegativePositive(string input)
        {
            double input_d = double.Parse(input);
            if (input_d != 0)
            {
                double result = input_d * (-1);
                return result.ToString();
            }
            else
            {
                return '0'.ToString();
            }
        }

    }
}

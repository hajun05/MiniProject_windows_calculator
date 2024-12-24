using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_windows_calculator
{
    internal class UnaryOperations
    {
        // %버튼
        public string[] Percent(string RHS_output, string LHS_output)
        {
            string[] result = new string[2];
            double RHS_output_d = double.Parse(RHS_output);
            if (LHS_output == "" || LHS_output == "0")
            {
                RHS_output = "0";
                LHS_output = "0";
            }
            else
            {
                RHS_output = (RHS_output_d / 100).ToString();
                LHS_output += RHS_output;
            }
            result[0] = RHS_output;
            result[1] = LHS_output;
            return result;
        }

        // 제곱 버튼 x^2
        public string[] Square(string RHS_output, string LHS_output)
        {
            string[] result = new string[2];
            double RHS_output_d = double.Parse(RHS_output);
            if (LHS_output == "")
            {
                LHS_output = "sqr(" + RHS_output + ")";
            }
            else if (LHS_output.Contains("sqr("))
            {
                int index = LHS_output.IndexOf("s");
                LHS_output = LHS_output.Insert(index, "sqr(");
                LHS_output += ")";
            }
            else
            {
                LHS_output += "sqr(" + RHS_output + ")";
            }
            RHS_output = (Math.Pow(RHS_output_d, 2)).ToString();
            result[0] = RHS_output;
            result[1] = LHS_output;
            return result;
        }

        // 제곱근(루트) 버튼
        public string[] Root(string RHS_output, string LHS_output)
        {
            string[] result = new string[2];
            double RHS_output_d = double.Parse(RHS_output);
            if (LHS_output == "")
            {
                LHS_output = "√(" + RHS_output +")";
            }
            else if (LHS_output.Contains("√"))
            {
                int index = LHS_output.IndexOf("√");
                LHS_output = LHS_output.Insert(index, "√(");
                LHS_output += ")";
            }
            else
            {
                LHS_output += "√(" + RHS_output + ")";
            }
            RHS_output = (Math.Sqrt(RHS_output_d)).ToString();
            result[0] = RHS_output;
            result[1] = LHS_output;
            return result;

        }

        // 분수 만들기 1/x
        public string[] Fraction(string RHS_output, string LHS_output)
        {
            string[] result = new string[2];
            double RHS_output_d = double.Parse(RHS_output);
            if (RHS_output_d == 0)
            {
                RHS_output = "0으로 나눌 수 없습니다.";
            }
            else
            {
                if(LHS_output == "")
                {
                    LHS_output = "1/(" + RHS_output +")";
                }
                else if (LHS_output.Contains("/"))
                {
                    int index = LHS_output.IndexOf("/");
                    LHS_output = LHS_output.Insert(index-1, "1/(");
                    LHS_output += ")";
                }
                else
                {
                    LHS_output += "1/(" + RHS_output + ")";
                }
                RHS_output = (1 / RHS_output_d).ToString();
            }
            result[0] = RHS_output;
            result[1] = LHS_output;
            return result;
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

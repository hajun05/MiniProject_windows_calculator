using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_windows_calculator
{
    internal class NumberButtons
    {
        // 숫자 0버튼
        public string ZeroButton (string RHS_output, string LHS_output, string recentlyInput)
        {
            //RHS 값이 0일때는 그대로, RHS에 다른 숫자가 있으면 뒤에 이어붙이기
            //LHS 값에 연산자가 있으면 RHS 새로 시작 -> 안됨,, 연산자가 있을때 두자리수 이상 입력이 안먹음
            //최근 입력값이 뭔지 전달받아서 연산자(oper)면 새로운 수 입력
            if (recentlyInput == "oper")
            {
                RHS_output = "0".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "0";
                }
            }
            return RHS_output; 
        }

        // 숫자 1버튼
        public string OneButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "1".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "1";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "1";
                }
            }
            return RHS_output;
        }

        // 숫자 2버튼
        public string TwoButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "2".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "2";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "2";
                }
            }
            return RHS_output;
        }

        //숫자 3버튼
        public string ThreeButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "3".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "3";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "3";
                }
            }
            return RHS_output;
        }

        // 숫자 4버튼
        public string FourButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "4".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "4";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "4";
                }
            }
            return RHS_output;
        }

        //숫자 5버튼
        public string FiveButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "5".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "5";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "5";
                }
            }
            return RHS_output;
        }

        //숫자 6버튼
        public string SixButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "6";
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "6";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "6";
                }
            }
            return RHS_output;
        }

        //숫자 7버튼
        public string SevenButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "7".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "7";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "7";
                }
            }
            return RHS_output;
        }

        //숫자 8버튼
        public string EightButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "8".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "8";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "8";
                }
            }
            return RHS_output;
        }

        //숫자 9버튼
        public string NineButton(string RHS_output, string LHS_output, string recentlyInput)
        {
            if (recentlyInput == "oper")
            {
                RHS_output = "9".ToString();
            }
            else
            {
                if (RHS_output != "0")
                {
                    RHS_output += "9";
                }
                // 0제외하고 나머지는 RHS값이 0이면 해당 숫자로 변경
                else
                {
                    RHS_output = "9";
                }
            }
            return RHS_output;
        }
    }
}

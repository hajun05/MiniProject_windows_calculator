using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_windows_calculator
{
    internal class AdditionalFunction
    {
        //소수점 표시
        public string DecimalPoint(string input)
        {
            if (!input.Contains('.'))
            {
                return input + '.';
            }
            else
            {
                return input;
            }
        }

    }
}

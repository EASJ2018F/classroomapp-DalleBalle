using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (input == "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public static class IntExtensions
    {
        public static int Reverse(this int number)
        {
            string num = number.ToString();

            List<char> numChars = num.Reverse().ToList();

            string numStr = string.Concat(numChars);

            return Convert.ToInt32(numStr);
        }
    }
}

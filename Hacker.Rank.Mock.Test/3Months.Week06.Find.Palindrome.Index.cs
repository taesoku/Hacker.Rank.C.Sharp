using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank.Mock.Test
{
    class _3MonthsWeek06FindPalindromeIndex
    {
        public static void Answer()
        {

        }

        public static int FindPalindromeIndex(string input)
        {
            var i = 0;
            var j = input.Length - 1;
            while (i < j)
            {
                if (input[i] != input[j])
                {
                    if (input[i + 1] == input[j] && input[i + 2] == input[j - 1]) return i;
                    else return j;
                }
                i++;
                j--;
            }
            return -1;
        }
    }
}

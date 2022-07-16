using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank.Mock.Test
{
    class _3MonthsWeek04CountAnagram
    {
        public static void Answer()
        {

        }

        public static int CountAnagram(string s)
        {
            var count = 0;
            var dictionary = new Dictionary<char, int>();
            var n = s.Length;
            if (n % 2 != 0) return -1;
            var first = s.Substring(0, n / 2);
            for (var i = n / 2; i < n; i++)
            {
                if (dictionary.ContainsKey(s[i])) dictionary[s[i]]++;
                else dictionary[s[i]] = 1;
            }
            foreach (var c in first)
            {
                if (dictionary.ContainsKey(c))
                {
                    if (dictionary[c] == 0) count++;
                    else dictionary[c]--;
                }
                else count++;
            }
            return count;
        }
    }
}

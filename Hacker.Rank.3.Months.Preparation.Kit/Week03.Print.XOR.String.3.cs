using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week03PrintXORString3
    {

        public static void Answer()
        {
            var input = "07:05:45PM";
            PrintXORString3(input, input);
        }

        private static string PrintXORString3(string s, string t)
        {
            var output = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
                if (s[i] == t[i]) output.Append("0");
                else output.Append("1");
            return output.ToString();
        }

    }
}

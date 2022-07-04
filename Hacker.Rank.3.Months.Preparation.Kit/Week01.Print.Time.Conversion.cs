using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week01PrintPlusMinus
    {

        public static void Answer()
        {
            var input = "07:05:45PM";
            PrintTimeConversion(input);
        }

        private static string PrintTimeConversion(string input)
        {
            var isAM = input.Contains("AM");

            var output = new StringBuilder();
            var splitted = input.Split(':').ToList();

            var hour = int.Parse(splitted[0]);
            if (isAM && hour == 12) hour = 0;
            else if (!isAM && hour != 12) hour += 12;

            output.Append(string.Format("{0:D2}", hour));
            output.Append(":");
            output.Append(splitted[1] + ":");
            output.Append(splitted[2].Substring(0, 2));

            return output.ToString();
        }

    }
}

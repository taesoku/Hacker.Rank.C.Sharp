using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week01PlusMinus
    {

        public static void Answer()
        {
            var inputs = new List<int> { -4, 3, -9, 0, 4, 1 };
            PlusMinus(inputs);
        }

        private static void PlusMinus(List<int> inputs)
        {
            var count = inputs.Count();
            var negative = 0d;
            var positive = 0d;
            var zero = 0d;
            foreach (var a in inputs)
            {
                if (a == 0) zero++;
                else if (a > 0) positive++;
                else negative++;
            }
            Console.WriteLine(string.Format("{0:N6}", positive > 0 ? positive / count : 0));
            Console.WriteLine(string.Format("{0:N6}", negative > 0 ? negative / count : 0));
            Console.WriteLine(string.Format("{0:N6}", zero > 0 ? zero / count : 0));
        }

    }
}

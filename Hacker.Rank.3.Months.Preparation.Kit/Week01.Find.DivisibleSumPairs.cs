using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week01FindDivisibleSumPairs
    {

        public static void Answer()
        {
            var inputs = new List<int> { 12, 24, 10, 24 };
        }

        private static int FindDivisibleSumPairs(List<int> inputs, int n, int k)
        {
            var count = 0;
            for (var i = 0; i < n - 1; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    var sum = ar[i] + ar[j];
                    if (sum % k == 0) count++;
                }
            }
            return count;
        }

    }
}

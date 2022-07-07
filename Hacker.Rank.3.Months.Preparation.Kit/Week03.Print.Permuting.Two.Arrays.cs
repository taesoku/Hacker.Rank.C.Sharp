using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week03PrintPermutingTwoArrays
    {

        public static void Answer()
        {
            var inputs1 = new List<int> { 1, 2, 3 };
            var inputs2 = new List<int> { 4, 5, 6 };
            PrintPermutingTwoArrays(3, inputs1, inputs2);
        }

        private static string PrintPermutingTwoArrays(int k, List<int> a, List<int> b)
        {
            a.Sort();
            b.Sort();
            b.Reverse();
            for (var i = 0; i < a.Count; i++)
                if (a[i] + b[i] < k) return "NO";
            return "YES";
        }

    }
}

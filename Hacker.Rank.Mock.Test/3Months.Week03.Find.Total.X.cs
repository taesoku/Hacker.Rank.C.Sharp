using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank.Mock.Test
{
    class _3MonthsWeek03FindTotalX
    {
        public static void Answer()
        {

        }

        public static int FindTotalX(List<int> a, List<int> b)
        {

            var temp = new List<int>();

            var max = b.First();
            var min = a.Last();

            for (var i = min; i <= max; i++)
            {
                var curr = true;
                var j = 0;
                var k = 0;
                while (j < a.Count || k < b.Count)
                {
                    if (j < a.Count && i % a[j] != 0)
                    {
                        curr = false;
                        break;
                    }
                    if (k < b.Count && b[k] % i != 0)
                    {
                        curr = false;
                        break;
                    }
                    j++;
                    k++;
                }
                if (curr) temp.Add(i);
            }

            return temp.Count;

        }
    }
}
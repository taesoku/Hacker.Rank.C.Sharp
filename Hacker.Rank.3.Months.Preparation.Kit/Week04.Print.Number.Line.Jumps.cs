using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week04PrintNumberLineJumps
    {

        public static void Answer()
        {
            PrintNumberLineJumps(1, 2, 3, 4);
        }

        private static string PrintNumberLineJumps(int x1, int v1, int x2, int v2)
        {
            if (v1 <= v2) return "NO";
            while (x1 <= int.MaxValue && x2 <= int.MaxValue)
            {
                if (x1 == x2) return "YES";
                else
                {
                    x1 += v1;
                    x2 += v2;
                }
                if (x1 > x2) return "NO";
            }
            return "NO";
        }

    }
}

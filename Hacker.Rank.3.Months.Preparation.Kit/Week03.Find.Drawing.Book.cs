using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week03FindDrawingBook
    {

        public static void Answer()
        {
            FindDrawingBook(5, 3);
        }

        private static int FindDrawingBook(int n, int p)
        {
            var count = 0;
            var i = 0;
            var j = n % 2 == 0 ? n + 1 : n;
            while (i < j)
            {
                if (i == p || i + 1 == p) return count;
                if (j == p || j - 1 == p) return count;
                i += 2;
                j -= 2;
                count++;
            }
            return count;
        }
    }
}

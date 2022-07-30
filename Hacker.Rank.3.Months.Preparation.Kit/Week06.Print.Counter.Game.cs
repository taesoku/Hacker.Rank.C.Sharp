using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week06PrintCounterGame
    {

        public static void Answer()
        {
            long inputs = 132;
            PrintCounterGame(inputs);
        }

        private static string PrintCounterGame(long n)
        {
            var player = true;
            while (n > 1)
            {
                if ((n & (n - 1)) != 0)
                {
                    var count = 0;
                    while ((n & (n - 1)) != 0)
                    {
                        n--;
                        count++;
                    }
                    n = count;
                }
                else
                    n = long.Parse(Math.Log(n, 2).ToString());
                player = !player;
            }
            return player ? "Louise" : "Richard";
        }

    }
}

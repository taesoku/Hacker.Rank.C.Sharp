using System;

namespace Hacker.Rank.Practice
{
    class _01Tutorials05Loops
    {

        public static void Answer()
        {
            PrintLoops();
        }

        public static void PrintLoops()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
        }

    }
}

using System;

namespace Hacker.Rank.Practice
{
    class _01Tutorials09Recursion
    {

        public static void Answer()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Recursion(n));
        }

        static int Recursion(int n)
        {
            if (n == 1) return 1;
            return n * Recursion(n - 1);
        }

    }
}

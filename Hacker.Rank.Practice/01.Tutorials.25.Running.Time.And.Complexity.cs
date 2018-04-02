using System;
using System.Collections.Generic;

namespace Hacker.Rank.Practice
{

    class _01Tutorials25RunningTimeAndComplexity
    {

        public static void Answer()
        {
            RunningTimeAndComplexity();
        }

        public static void RunningTimeAndComplexity()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var inputs = new int[n];
            for (int i = 0; i < n; i++)
            {
                inputs[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                IsPrime(inputs[i]);
            }
        }

        static void IsPrime(int n)
        {
            if (n == 2)
            {
                Console.WriteLine("Prime");
                return;
            }
            if (n <= 1 || n % 2 == 0)
            {
                Console.WriteLine("Not prime");
                return;
            }
            var sqrt = Math.Sqrt(n);
            for (int i = 3; i < sqrt + 1; i += 2)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not prime");
                    return;
                }
            }
            Console.WriteLine("Prime");
        }


    }

}

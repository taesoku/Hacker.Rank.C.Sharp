using System;

namespace Hacker.Rank.Practice
{

    class _01Tutorials17MoreExceptions
    {

        public static void Answer()
        {
            MoreExceptions();
        }


        public static void MoreExceptions()
        {
            var myCalculator = new Calculator17();
            var input = Int32.Parse(Console.ReadLine());
            while (input-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }

    class Calculator17
    {
        public Calculator17() { }
        public int power(int n, int p)
        {
            var power = 1;
            if (n < 0 || p < 0) throw new Exception("n and p should be non-negative");
            while (p-- > 0)
                power *= n;
            return power;
        }
    }

}

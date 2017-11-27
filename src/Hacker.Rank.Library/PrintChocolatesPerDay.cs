using System;

namespace Hacker.Rank.Library
{
    class PrintChocolatesPerDay
    {

        public static void Answer()
        {
            var inputs = new int[2];
            PrintChocolatesPerDayWithArray(inputs);
        }

        public static void PrintChocolatesPerDayWithArray(int[] inputs)
        {
            foreach (int i in inputs)
            {
                double temp = i % 2 == 1 ? i / 2 + 1 : (i - 1) / 2 + 1;
                if (i == 2) temp = 1;
                Console.WriteLine(temp*temp);
            }
        }

    }
}

using System;

namespace Hacker.Rank.Practice
{
    class _01Tutorials10BinaryNumbers
    {

        public static void Answer()
        {
            BinaryNumbers();
        }

        static void BinaryNumbers()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var binary = Convert.ToString(n, 2);
            var count = 0;
            var max = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i].ToString() == "1") count++;
                else if (binary[i].ToString() == "0") count = 0;
                if (count > max) max = count;
            }
            Console.WriteLine(max);
        }

    }
}

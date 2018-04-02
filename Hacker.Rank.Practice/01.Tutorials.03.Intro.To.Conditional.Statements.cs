using System;
using System.Text;

namespace Hacker.Rank.Practice
{
    class _01Tutorials03IntroToConditionalStatements
    {

        public static void Answer()
        {
            RunIntroToConditionalStatements();
        }

        public static void RunIntroToConditionalStatements()
        {
            var N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 1) Console.WriteLine("Weird");
            else
            {
                if (N >= 6 && N <= 20) Console.WriteLine("Weird");
                else Console.WriteLine("Not Weird");
            }
        }

    }
}

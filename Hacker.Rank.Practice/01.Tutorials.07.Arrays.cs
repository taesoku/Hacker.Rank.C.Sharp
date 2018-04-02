using System;

namespace Hacker.Rank.Practice
{
    class _01Tutorials07Arrays
    {

        public static void Answer()
        {
            Arrays();
        }

        static void Arrays()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr_temp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arr_temp, Int32.Parse);
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");
        }

    }
}

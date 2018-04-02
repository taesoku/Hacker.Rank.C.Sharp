using System;

namespace Hacker.Rank.Practice
{

    class _01Tutorials20Sorting
    {

        public static void Answer()
        {
            Sorting();
        }


        public static void Sorting()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            BubbleSort(inputs, inputs.Length);
        }

        static void BubbleSort(int[] inputs, int n, int loop = 1, int swap = 0)
        {
            var isSorted = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (inputs[i] > inputs[i + 1])
                {
                    var temp = inputs[i];
                    inputs[i] = inputs[i + 1];
                    inputs[i + 1] = temp;
                    isSorted = false;
                    swap++;
                }
            }
            if (isSorted)
            {
                Console.WriteLine("Array is sorted in " + swap + " swaps.");
                Console.WriteLine("First Element: " + inputs[0]);
                Console.WriteLine("Last Element: " + inputs[inputs.Length - 1]);
            }
            else BubbleSort(inputs, n - 1, ++loop, swap);
        }

    }

}

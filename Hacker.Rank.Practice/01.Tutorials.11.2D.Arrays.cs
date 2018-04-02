using System;

namespace Hacker.Rank.Practice
{
    class _01Tutorials11TwoDArrays
    {

        public static void Answer()
        {
            TwoDArrays();
        }

        static void TwoDArrays()
        {
            var arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                var arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            var max = arr[0][0] + arr[0][1] + arr[0][2] + arr[1][1] + arr[2][0] + arr[2][1] + arr[2][2];
            for (int i = 0; i <= arr.Length - 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    var temp = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (max < temp) max = temp;
                }
            }
            Console.WriteLine(max);
        }

    }
}

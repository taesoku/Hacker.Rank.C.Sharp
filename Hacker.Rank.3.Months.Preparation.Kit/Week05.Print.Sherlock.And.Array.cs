using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week05PrintSherlockAndArray
    {

        public static void Answer()
        {
            var inputs = new List<int> { 75, 26, 45, 72, 81, 47, 29, 97, 2, 75, 25, 82, 84, 17, 56, 32, 2, 28, 37, 57, 39, 18, 11, 79, 6, 40, 68, 68, 16, 40, 63, 93, 49, 91, 10, 55, 68, 31, 80, 57, 18, 34, 28, 76, 55, 21, 80, 22, 45, 11, 67, 67, 74, 91, 4, 35, 34, 65, 80, 21, 95, 1, 52, 25, 31, 2, 53, 96, 22, 89, 99, 7, 66, 32, 2, 68, 33, 75, 92, 84, 10, 94, 28, 54, 12, 9, 80, 43, 21, 51, 92, 20, 97, 7, 25, 67, 17, 38, 100, 86 };

            PrintSherlockAndArray(inputs);
        }

        private static string PrintSherlockAndArray(List<int> inputs)
        {
            var i = 0;
            var j = inputs.Count - 1;
            var left = inputs[i];
            var right = inputs[j];
            while (i < j)
            {
                if (left < right)
                    left += inputs[++i];
                else if (left > right)
                    right += inputs[--j];
                else
                {
                    if (i + 2 == j) return "YES";
                    left = 0;
                    right = 0;
                    if (inputs[i + 1] < inputs[j - 1])
                        left += inputs[++i];
                    else if (inputs[i + 1] > inputs[j - 1])
                        right += inputs[--j];
                    else
                    {
                        left += inputs[++i];
                        right += inputs[--j];
                    }
                }
            }
            if (left == right && (i == inputs.Count - 1 || j == 0)) return "YES";
            return i + 2 <= j ? "YES" : "NO";
        }

    }
}

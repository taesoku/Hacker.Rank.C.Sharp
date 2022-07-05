using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week03SubarrayDivision2
    {

        public static void Answer()
        {
            var inputs4 = new List<int> {4,5,4,2,4,5,2,3,2,1,1,5,4};
            var output4 = SubarrayDivision2(inputs4, 15, 4);
        }

        /*
         * Complete the 'birthday' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY s
         *  2. INTEGER d
         *  3. INTEGER m
         */

        private static int SubarrayDivision2(List<int> inputs, int day, int month)
        {
            var i = 0;
            var count = 0;
            var sum = 0;
            while (i < inputs.Count)
            {
                sum += inputs[i];
                if (i >= month - 1)
                {
                    if (i >= month) sum -= inputs[i - month];
                    if (day == sum) count++;
                }
                i++;
            }

            return count;
        }
         
    }
}

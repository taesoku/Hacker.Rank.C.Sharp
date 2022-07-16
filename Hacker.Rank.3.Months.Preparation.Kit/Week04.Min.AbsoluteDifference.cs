using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week04MinAbsoluteDifference
    {

        public static void Answer()
        {
            var inputs = new List<int>();
            MinAbsoluteDifference(inputs);
        }

        private static int MinAbsoluteDifference(List<int> inputs)
        {
            inputs.Sort();
            var min = int.MaxValue;

            for (var i = 1; i < inputs.Count; i++)
            {
                var curr = Math.Abs(inputs[i] - inputs[i - 1]);
                min = curr < min ? curr : min;
            }
            return min;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week01RunMiniMaxSum
    {
        public static void Answer()
        {

        }

        public static void RunMiniMaxSum(List<int> inputs)
        {
            var max = inputs[0];
            var min = inputs[0];
            var sum = 0L;
            for (var i = 0; i < inputs.Count(); i++)
            {
                if (inputs[i] > max) max = inputs[i];
                else if (inputs[i] < min) min = inputs[i];
                sum += inputs[i];
            }
            Console.Write(sum - max);
            Console.Write(" ");
            Console.Write(sum - min);
        }

    }
}

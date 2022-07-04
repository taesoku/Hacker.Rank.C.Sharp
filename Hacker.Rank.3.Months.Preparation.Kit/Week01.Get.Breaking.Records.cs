using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week01GetBreakingRecords
    {

        public static void Answer()
        {
            var inputs = new List<int> { 12, 24, 10, 24 };
            GetBreakingRecords(inputs);
        }

        private static List<int> GetBreakingRecords(List<int> inputs)
        {
            if (inputs == null) return new List<int>();
            if (inputs.Count() == 0) return new List<int> { 0, 0 };
            var currMax = inputs[0];
            var currMin = inputs[0];
            var countMax = 0;
            var countMin = 0;
            for (var i = 1; i < inputs.Count(); i++)
            {
                if (inputs[i] > currMax)
                {
                    countMax++;
                    currMax = inputs[i];
                }
                else if (inputs[i] < currMin)
                {
                    countMin++;
                    currMin = inputs[i];
                }
            }
            return new List<int> { countMax, countMin };
        }

    }
}

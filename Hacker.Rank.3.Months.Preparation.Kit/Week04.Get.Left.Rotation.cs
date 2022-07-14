using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week04GetLeftRotation
    {

        public static void Answer()
        {
            var inputs1 = new List<int> { 5, 2, 3, 4, 1 };
            GetLeftRotation(inputs1, 1);
        }

        private static List<int> GetLeftRotation(List<int> inputs, int r)
        {
            var n = inputs.Count;
            if (n == r) return inputs;
            for (var i = 0; i < n; i++)
                inputs.Add(inputs[i]);
            return inputs.GetRange(r, n);
        }
    }
}

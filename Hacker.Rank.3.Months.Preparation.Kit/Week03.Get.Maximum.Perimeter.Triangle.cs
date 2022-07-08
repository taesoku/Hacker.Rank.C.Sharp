using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week03GetMaximumPerimeterTriangle
    {

        public static void Answer()
        {
            var inputs = new List<int> { 1, 2, 3, 4, 5, 10 };
            GetMaximumPerimeterTriangle(inputs);
        }

        private static List<int> GetMaximumPerimeterTriangle(List<int> inputs)
        {
            inputs.Sort();
            var outputs = new List<int>();
            for (var i = inputs.Count - 1; i >= 2; i--)
                for (var j = inputs.Count - 2; j >= 1; j--)
                    for (var k = inputs.Count - 3; k >= 0; k--)
                    {
                        if (i == j || j == k || i == k) continue;
                        var a = inputs[i];
                        var b = inputs[j];
                        var c = inputs[k];
                        if (a + b > c && a + c > b && b + c > a)
                        {
                            outputs.Add(a);
                            outputs.Add(b);
                            outputs.Add(c);
                            return outputs;
                        }
                    }
            outputs.Add(-1);
            return outputs;
        }
    }
}

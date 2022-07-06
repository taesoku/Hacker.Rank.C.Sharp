using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week03CountSalesByMatch
    {

        public static void Answer()
        {
            var inputs4 = new List<int> {4,5,4,2,4,5,2,3,2,1,1,5,4};
            var output4 = CountSalesByMatch(inputs4);
        }

        private static int CountSalesByMatch(List<int> inputs)
        {
            var count = 0;
            var dictionary = new Dictionary<int, int>();
            foreach (var i in inputs)
                dictionary[i] = dictionary.ContainsKey(i) ? dictionary[i] + 1 : 1;
            foreach (var d in dictionary)
                count += d.Value / 2;
            return count;
        }
         
    }
}

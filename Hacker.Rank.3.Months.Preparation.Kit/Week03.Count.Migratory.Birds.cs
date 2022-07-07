using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week03CountMigratoryBirds
    {

        public static void Answer()
        {
            var inputs4 = new List<int> {4,5,4,2,4,5,2,3,2,1,1,5,4};
            var output4 = CountMigratoryBirds(inputs4);
        }

        private static int CountMigratoryBirds(List<int> inputs)
        {
            var dictionary = new Dictionary<int, int>();
            dictionary[inputs[0]] = 1;
            var curr = inputs[0];
            var max = 1;
            for (var i = 1; i < inputs.Count; i++)
            {
                if (dictionary.ContainsKey(inputs[i]))
                {
                    var count = dictionary[inputs[i]] + 1;
                    dictionary[inputs[i]] = count;
                    if (count >= max)
                    {
                        curr = inputs[i] < curr || count > max ? inputs[i] : curr;
                        max = count;
                    }
                }
                else dictionary[inputs[i]] = 1;
            }
            return curr;
        }
         
    }
}

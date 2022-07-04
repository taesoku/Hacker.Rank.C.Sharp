using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week01GetMatchingStrings
    {

        public static void Answer()
        {
            var strings = new List<string> { "aba", "baba", "aba", "xzxb" };
            var queries = new List<string> { "aba", "xzxb", "ab" };
            GetMatchingStrings(strings, queries);
        }

        private static List<int> GetMatchingStrings(List<string> strings, List<string> queries)
        {
            var outputs = new List<int>();
            foreach (var query in queries)
            {
                var count = 0;
                for (var j = 0; j < strings.Count(); j++)
                    if (query.Contains(strings[j])) count++;
                outputs.Add(count);
            }
            return outputs;
        }
    }
}

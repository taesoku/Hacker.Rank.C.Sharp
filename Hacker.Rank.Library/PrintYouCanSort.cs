using System;
using System.Collections.Generic;
using System.Linq;

namespace Hacker.Rank.Library
{
    class PrintYouCanSort
    {

        public static void Answer()
        {
            var inputs = new int[2];
            PrintYouCanSortDictionary(inputs);
        }

        public static void PrintYouCanSortDictionary(int[] inputs)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (var input in inputs)
            {
                if (dictionary.ContainsKey(input))
                {
                    var temp = dictionary[input];
                    dictionary[input] = temp + 1;
                }
                else dictionary[input] = 1;
            }
            var ordered = dictionary.OrderBy(d => d.Key).OrderBy(d => d.Value);
            foreach (var o in ordered)
            {
                for (var i = 0; i < o.Value; i++) Console.WriteLine(o.Key);
            }
        }

    }
}

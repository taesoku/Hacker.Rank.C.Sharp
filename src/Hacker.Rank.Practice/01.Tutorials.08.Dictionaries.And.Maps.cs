using System;
using System.Collections;

namespace Hacker.Rank.Practice
{
    class _01Tutorials08DictionariesAndMaps
    {

        public static void Answer()
        {
            DictionariesAndMaps();
        }

        static void DictionariesAndMaps()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var outputs = new Hashtable();
            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine().Split(' ');
                outputs[temp[0]] = temp[1];
            }
            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine();
                if (outputs.ContainsKey(temp))
                {
                    var output = outputs[temp];
                    Console.WriteLine(temp + "=" + output);
                }
                else Console.WriteLine("Not found");
            }
        }

    }
}

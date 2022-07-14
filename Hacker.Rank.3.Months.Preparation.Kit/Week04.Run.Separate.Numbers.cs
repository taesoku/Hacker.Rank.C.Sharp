using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week04RunSeparateNumbers
    {

        public static void Answer()
        {
            var input1 = "010203";
            var input2 = "10001001100210031004100510061007";
            var input3 = "10001001100210031004100510061007";
            RunSeparateNumbers(input3);
        }

        private static void RunSeparateNumbers(string input)
        {
            if (input[0] == '0' || input.Distinct().Count() < 2) 
            {
                Console.WriteLine("NO");
                return;
            }

            var i = input.Length / 2;
            var first = 0L;

            while (i > 0)
            {

                if (!long.TryParse(input.Substring(0, i), out first))
                {
                    i--;
                    continue;
                }
                var temp = first;
                var j = i;
                var match = true;
            
                while (j < input.Length)
                {
                    var curr = ++temp;
                    var length = curr.ToString().Length;
                    if (long.Parse(input.Substring(j, 1)) == 0) 
                        length++;
                    if (j + length > input.Length || curr != long.Parse(input.Substring(j, length)))
                    {
                        match = false;
                        break;
                    }
                    j += length;
                }
            
                if (match)
                {
                    Console.WriteLine("YES " + first);
                    return;
                }
                i--;
            }
            Console.WriteLine("NO");
        }

    }
}

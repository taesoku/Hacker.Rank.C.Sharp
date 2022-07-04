using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week01RunCamelCase4
    {
        public static void Answer()
        {

        }

        public static void RunCamelCase4()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == null || input.Length == 0) break;
                var splits = input.Split(';').ToList();
                var output = splits.Last();
                if (splits[0] == "S")
                {
                    output = new Regex(@"(?<=[^A-Z])(?=[A-Z])", RegexOptions.IgnorePatternWhitespace).Replace(output, " ").ToLower();
                    if (splits[1] == "M")
                        output = output.Replace("(", "").Replace(")", "").Trim();
                }
                else if (splits[0] == "C")
                {
                    output = Regex.Replace(output, @"\b\w", (Match match) => match.ToString().ToUpper());
                    output = output.Replace(" ", "");
                    if (splits[1] != "C")
                        output = char.ToLower(output[0]).ToString() + output.Substring(1);
                    if (splits[1] == "M")
                        output = output + "()";
                }

                Console.WriteLine(output);
            }
        }

    }
}

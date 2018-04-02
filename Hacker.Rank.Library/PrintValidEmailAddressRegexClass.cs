using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hacker.Rank.Library
{
    class PrintValidEmailAddressRegexClass
    {

        static string regularExpression = @"^([a-z]{0,5}[_]{0,1}[0-9]{0,4})@hackerrank.com$";

        public static void Answer()
        {
            var inputs = new List<string>
            {
                "julia@hackerrank.com",
                "julia_@hackerrank.com",
                "julia_0@hackerrank.com",
                "julia0_@hackerrank.com",
                "julia@gmail.com"
            };
            PrintValidEmailAddressesRegex(5, inputs);
            
        }

        public static void PrintValidEmailAddressesRegex(int n, List<string> inputs)
        {
            for (int i = 0; i < n; i++)
            {
                
                var temp = inputs[i].Split('@');

                if (temp.Last() != "hackerrank.com")
                {
                    Console.WriteLine("False");
                    continue;
                }

                var regexPattern = @"^([a-z]{1,6})+$"; // the first condition
                var matches = Regex.Match(temp.First(), regexPattern);

                if (matches.Success)
                {
                    Console.WriteLine("True");
                    continue;
                }

                regexPattern = @"^([a-z]{0,5}[_]{1})+$"; // the second condition
                matches = Regex.Match(temp.First(), regexPattern);
                if (matches.Success)
                {
                    Console.WriteLine("True");
                    continue;
                }

                regexPattern = @"^([a-z]{0,5}[_]{1}[0-9]{1,4})+$"; // the third condition
                matches = Regex.Match(temp.First(), regexPattern);
                if (matches.Success)
                {
                    Console.WriteLine("True");
                    continue;
                }

                Console.WriteLine("False");

            }
        }

    }
}

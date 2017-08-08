using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hacker.Rank.Practice
{

    class _01Tutorials26NestedLogic
    {

        public static void Answer()
        {
            NestedLogic("20 1 2004", "31 8 2004");
        }

        public static void NestedLogic(string a, string b)
        {
            var input1 = a.Split(' ').ToList();
            var input2 = b.Split(' ').ToList();
            var firstDay = int.Parse(input1[0]);
            var firstMonth = int.Parse(input1[1]);
            var firstYear = int.Parse(input1[2]);

            var secondDay = int.Parse(input2[0]);
            var secondMonth = int.Parse(input2[1]);
            var secondYear = int.Parse(input2[2]);
            var first = firstDay + CountMonth(firstMonth, firstYear) + CountYear(firstYear, firstMonth);
            var second = secondDay + CountMonth(secondMonth, secondYear) + CountYear(secondYear, secondMonth);
            if (first >= second)
            {
                Console.WriteLine(0);
                return;
            }
            if (firstYear != secondYear) Console.WriteLine(10000);
            else if (CountMonth(secondMonth, secondYear) != CountMonth(firstMonth, firstYear))
            {
                Console.WriteLine((firstMonth - secondMonth)*500);
            }
            else Console.WriteLine(Math.Abs(secondDay - firstDay) * 15);
        }

        static int CountMonth(int month, int year)
        {
            var days = 0;
            for (int i = 1; i < month; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10)
                    days += 31;
                else if (i == 4 || i == 6 || i == 9 || i == 11) days += 30;
                else if (year % 4 == 0) days += 29;
                else days += 28;
            }
            return days;
        }

        static int CountYear(int year, int month)
        {
            return year * 365 + year / 4 - (year % 4 == 0 && month < 3 ? 1 : 0);
        }

    }

}
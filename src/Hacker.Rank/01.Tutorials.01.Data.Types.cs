using System;
using System.Text;

namespace Hacker.Rank.Practice
{
    class _01Tutorials01DataTypes
    {

        public static void Answer()
        {
            RunDataTypes();
        }

        public static void RunDataTypes()
        {
            var i = 4;
            var d = 4.0d;
            var s = "HackerRank ";
            // Declare second integer, double, and String variables.

            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.
            var read1 = int.Parse(Console.ReadLine());
            Console.WriteLine(i + read1);

            // Print the sum of the double variables on a new line.
            var read2 = d + double.Parse(Console.ReadLine());
            Console.WriteLine("{0:N1}", read2);


            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            var read3 = Console.ReadLine();
            Console.WriteLine(s + read3); 
        }

    }
}

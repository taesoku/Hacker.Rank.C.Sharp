using System;
using System.Text;

namespace Hacker.Rank.Practice
{
    class _01Tutorials00HelloWorld
    {

        public static void Answer()
        {
            RunHelloWorld("Hello World");
        }

        public static void RunHelloWorld(string input)
        {
            // Declare a variable named 'inputString' to hold our input.
            var inputString = new StringBuilder();
            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            Console.WriteLine("Hello, World.");
            // Print a string literal saying "Hello, World." to stdout using cout.
            // TODO: Write a line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(inputString);
        }

    }
}

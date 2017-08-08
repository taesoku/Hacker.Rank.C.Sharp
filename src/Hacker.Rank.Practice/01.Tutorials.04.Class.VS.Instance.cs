using System;

namespace Hacker.Rank.Practice
{
    class _01Tutorials04ClassVSInstance
    {

        public static void Answer()
        {
            
        }

        public int Age;

        public _01Tutorials04ClassVSInstance(int initialAge)
        {
            if (initialAge < 0)
                Console.WriteLine("Age is not valid, setting age to 0.");
            else Age = initialAge;
        }

        public void AmIOld()
        {
            if (Age < 13) Console.WriteLine("You are young.");
            else if (Age >= 13 && Age < 18) Console.WriteLine("You are a teenager.");
            else Console.WriteLine("You are old.");
            // Do some computations in here and print out the correct statement to the console 
        }

        public void YearPasses()
        {
            Age++;
            // Increment the age of the person in here
        }

    }
}

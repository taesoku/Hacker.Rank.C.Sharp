using System;

namespace Hacker.Rank.Practice
{

    class _01Tutorials16Exceptions
    {

        public static void Answer()
        {
            Exceptions();
        }

        public static void Exceptions()
        {
            var input = Console.ReadLine();
            try
            {
                Console.WriteLine(Convert.ToInt32(input));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }

}

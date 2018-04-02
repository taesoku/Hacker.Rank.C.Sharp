using System;
using System.Collections;

namespace Hacker.Rank.Practice
{

    class _01Tutorials21Generics
    {

        public static void Answer()
        {
            Generics();
        }

        public static void Generics()
        {
            var vInt = new[] {1, 2, 3};
            var vString = new[] {"Hello", "World"};
            PrintArray<int>(vInt);
            PrintArray<string>(vString);
        }

        private static void PrintArray<T>(object input)
        {
            var collection = input as IEnumerable;
            foreach (var c in collection) Console.WriteLine(c);
        }

    }

}

using System;
using System.Linq;

namespace Hacker.Rank.Practice
{

    class _01Tutorials14Scope
    {

        public static void Answer()
        {
            Scope();
        }

        static void Scope()
        {
            Convert.ToInt32(Console.ReadLine());
            var a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            var d = new Difference(a);
            d.ComputeDifference();
            Console.Write(d.maximumDifference);
        }

    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] a)
        {
            elements = a.OrderBy(e => e).ToArray();
        }
        public void ComputeDifference()
        {
            maximumDifference = elements.Last() - elements.First();
        }
    }

}

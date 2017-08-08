using System;
using System.Collections.Generic;

namespace Hacker.Rank.Practice
{

    class _01Tutorials19Interfaces
    {

        public static void Answer()
        {
            Interfaces();
        }


        public static void Interfaces()
        {
            int n = Int32.Parse(Console.ReadLine());
            var myCalculator = new Calculator19();
            int sum = myCalculator.DivisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
        }

    }

    public interface AdvancedArithmetic
    {
        int DivisorSum(int n);
    }

    class Calculator19 : AdvancedArithmetic
    {
        public Calculator19() { }

        public int DivisorSum(int n)
        {
            var sum = n;
            for (int i = n - 1; i > 0; i--)
                sum += n % i == 0 ? i : 0;
            return sum;
        }

    }

}

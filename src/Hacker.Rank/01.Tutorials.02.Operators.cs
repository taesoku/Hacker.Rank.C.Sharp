using System;
using System.Text;

namespace Hacker.Rank.Practice
{
    class _01Tutorials02Operators
    {

        public static void Answer()
        {
            RunOperators();
        }

        public static void RunOperators()
        {
            var mealCost = double.Parse(Console.ReadLine());
            var tipPercent = (double)int.Parse(Console.ReadLine()) / 100;
            var taxPercent = (double)int.Parse(Console.ReadLine()) / 100;
            var totalCost = mealCost + mealCost * tipPercent + mealCost * taxPercent;
            var totalCostString = new StringBuilder();
            totalCostString.Append("The total meal cost is ");
            totalCostString.Append(Math.Round(totalCost));
            totalCostString.Append(" dollars.");
            Console.WriteLine(totalCostString.ToString());
        }

    }
}

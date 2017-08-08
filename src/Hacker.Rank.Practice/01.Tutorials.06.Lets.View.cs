using System;
using System.Text;

namespace Hacker.Rank.Practice
{
    class _01Tutorials06LetsReview
    {

        public static void Answer()
        {
            LetsReview("hacker");
        }

        static void LetsReview(string input)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            //var n = Convert.ToInt32(Console.ReadLine());
            while (true)
            //while(n > 0)
            {
                //var input = Console.ReadLine();
                var inputs = input.ToCharArray();
                var output = new StringBuilder();
                for (int i = 0; i < inputs.Length; i += 2)
                    output.Append(inputs[i]);
                output.Append(" ");
                for (int i = 1; i < inputs.Length; i += 2)
                    output.Append(inputs[i]);
                Console.WriteLine(output.ToString());
                //n--;
                break;
            }
        }

        static void Sort(char[] inputs, int middle)
        {
            for (int i = middle; i < inputs.Length; i++)
            {
                for (int j = i; j > middle; j--)
                {
                    if (inputs[j - 1] > inputs[j])
                    {
                        var temp = inputs[j - 1];
                        inputs[j - 1] = inputs[j];
                        inputs[j] = temp;
                    }
                    else break;
                }
            }
        }

        static void Swap(char[] inputs, int x, int y)
        {
            var temp = inputs[x];
            inputs[x] = inputs[y];
            inputs[y] = temp;
        }

    }
}

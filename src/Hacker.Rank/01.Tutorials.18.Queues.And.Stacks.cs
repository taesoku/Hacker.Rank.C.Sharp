using System;
using System.Collections.Generic;

namespace Hacker.Rank.Practice
{

    class _01Tutorials18QueuesAndStacks
    {

        public static void Answer()
        {
            QueuesAndStacks();
        }


        public static void QueuesAndStacks()
        {
            string s = Console.ReadLine();

            // create the Solution class object p.
            var obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.PushCharacter(c);
                obj.EnqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.PopCharacter() != obj.DequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }

    }

    class Solution
    {
        
        private Queue<char> queues;
        private Stack<char> stacks;

        public Solution()
        {
            queues = new Queue<char>();
            stacks = new Stack<char>();
        }

        public void EnqueueCharacter(char c)
        {
            queues.Enqueue(c);
        }

        public void PushCharacter(char c)
        {
            stacks.Push(c);
        }

        public char PopCharacter()
        {
            return stacks.Pop();
        }

        public char DequeueCharacter()
        {
            return queues.Dequeue();
        }

    }

}

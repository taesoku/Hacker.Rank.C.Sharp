using System;
using System.Collections.Generic;

namespace Hacker.Rank.Practice
{

    class _01Tutorials24MoreLinkedList
    {

        public static void Answer()
        {
            MoreLinkedList();
        }

        class Node
        {
            public int Data;
            public Node Next;
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public static void MoreLinkedList()
        {
            var head = (Node) null;
            var T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                var data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }
            head = RemoveDuplicates(head);
            Display(head);
        }

        static void Display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.Data + " ");
                start = start.Next;
            }
        }

        static Node Insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.Next == null)
                head.Next = p;
            else
            {
                Node start = head;
                while (start.Next != null)
                    start = start.Next;
                start.Next = p;

            }
            return head;
        }

        static Node RemoveDuplicates(Node head)
        {
            var hashset = new HashSet<int>();
            var curr = head;
            var previous = (Node)null;

            while (curr != null)
            {
                if (!hashset.Contains(curr.Data))
                {
                    hashset.Add(curr.Data);
                    previous = curr;
                }
                else previous.Next = curr.Next;
                curr = curr.Next;
            }
            return head;
        }

    }

}

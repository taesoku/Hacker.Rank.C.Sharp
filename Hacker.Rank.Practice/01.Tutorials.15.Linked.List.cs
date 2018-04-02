using System;

namespace Hacker.Rank.Practice
{

    class _01Tutorials15LinkedList
    {

        public static void Answer()
        {
            LinkedList();
        }

        public static void LinkedList()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static Node insert(Node head, int data)
        {
            if (head == null) return new Node(data);
            var curr = head;
            var temp = new Node(data);
            while (curr.next != null)
                curr = curr.next;
            curr.next = temp;
            return head;
        }

    }

    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

}

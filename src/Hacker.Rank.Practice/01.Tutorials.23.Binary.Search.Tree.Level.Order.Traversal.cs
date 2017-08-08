using System;
using System.Collections;

namespace Hacker.Rank.Practice
{

    class _01Tutorials23BianrySearchTreeLevelOrderTraversal
    {

        public static void Answer()
        {
            BianrySearchTreeLevelOrderTraversal();
        }

        class Node
        {
            public Node Left, Right;
            public int Data;
            public Node(int data)
            {
                Data = data;
                Left = Right = null;
            }
        }

        public static void BianrySearchTreeLevelOrderTraversal()
        {
            var root = (Node) null;
            var T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                var data = Int32.Parse(Console.ReadLine());
                root = Insert(root, data);
            }
            LevelOrder(root);
        }

        static Node Insert(Node root, int data)
        {
            if (root == null) return new Node(data);
            Node cur;
            if (data <= root.Data)
            {
                cur = Insert(root.Left, data);
                root.Left = cur;
            }
            else
            {
                cur = Insert(root.Right, data);
                root.Right = cur;
            }
            return root;
        }

        static void LevelOrder(Node root)
        {
            var q = new Queue();
            if (root == null) return;
            q.Enqueue(root);
            while (q.Count != 0)
            {
                var n = (Node) q.Dequeue();
                Console.Write(" " + n.Data);
                if (n.Left != null) q.Enqueue(n.Left);
                if (n.Right != null) q.Enqueue(n.Right);
            }
        }

    }

}

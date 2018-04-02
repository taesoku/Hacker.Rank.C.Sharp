using System;

namespace Hacker.Rank.Practice
{

    class _01Tutorials22BinarySearchTree
    {

        public static void Answer()
        {
            BinarySearchTree();
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

        public static void BinarySearchTree()
        {
            var root = (Node) null;
            var t = Int32.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = InsertNode(root, data);
            }
            int height = GetHeight(root);
            Console.WriteLine(height);
        }

        static int GetHeight(Node root, int max = 0)
        {
            if (root == null) return max - 1;
            var left = GetHeight(root.Left, max + 1);
            var right = GetHeight(root.Right, max + 1);
            return left > right ? left : right;
        }

        static Node InsertNode(Node root, int data)
        {
            if (root == null) return new Node(data);
            Node cur;
            if (data <= root.Data)
            {
                cur = InsertNode(root.Left, data);
                root.Left = cur;
            }
            else
            {
                cur = InsertNode(root.Right, data);
                root.Right = cur;
            }
            return root;
        }

    }

}

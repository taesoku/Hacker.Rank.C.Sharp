using System;

namespace Hacker.Rank.Library
{
    class GetBinarySearchTreePresent
    {

        public static void Answer()
        {

        }

        public class Node
        {
            public int Data;
            public Node Left, Right;

            Node(int data)
            {
                Data = data;
                Left = Right = null;
            }
        }

        public static int GetBinarySearchTreePresentRecursive(Node root, int val)
        {
            if (root == null) return 0;
            if (root.Data == val) return 1;
            if (root.Data > val) return GetBinarySearchTreePresentRecursive(root.Left, val);
            return GetBinarySearchTreePresentRecursive(root.Right, val);
        }

    }
}

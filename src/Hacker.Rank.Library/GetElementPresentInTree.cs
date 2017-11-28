namespace Hacker.Rank.Library
{
    class GetElementPresentInTree
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

        public static int GetElementPresentInTreeRecursive(Node root, int val)
        {
            if (root == null) return 0;
            if (root.Data == val) return 1;
            if (root.Data > val) return GetElementPresentInTreeRecursive(root.Left, val);
            return GetElementPresentInTreeRecursive(root.Right, val);
        }

    }
}

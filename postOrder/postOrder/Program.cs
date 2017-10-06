using System;

namespace postOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            Node root = new Node(1);
            Tree tree = new Tree(root);
            root.right = new Node(2);
            root.left = new Node(3);
            root.right.right = new Node(4);
            root.right.left = new Node(5);
            root.left.left = new Node(6);
            root.left.right = new Node(7);

            string InOrderString = "";
            tree.PrintTree(root, ref InOrderString);

            tree.BreadthFirst();
            Console.Read();
        }
    }
}

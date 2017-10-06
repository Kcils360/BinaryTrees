using System;
using System.Collections.Generic;
using System.Text;

namespace breadthFirst
{
    class Tree
    {
        public Node root;

        public Tree(Node data)
        {
            root = data;
        }

        public void PrintTree(Node L, ref string s)
        {
            if (L.left != null)
            {
                PrintTree(L.left, ref s);
                s = s + L.Value.ToString().PadLeft(3);
            }
            else
            {
                s = s + L.Value.ToString().PadLeft(3);
            }
            if (L.right != null)
            {
                PrintTree(L.right, ref s);
            }
            Console.WriteLine(s);
        }

        public void PostOrder(Node L, ref string s)
        {
            if (L.left != null)
            {
                PostOrder(L.left, ref s);
                if (L.right != null)
                {
                    PostOrder(L.right, ref s);
                }
                s = s + L.Value.ToString().PadLeft(3);

            }
            else
            {
                s = s + L.Value.ToString().PadLeft(3);
            }
            Console.WriteLine(s);
        }


        public void BreadthFirst(Node data)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(data);
            while (queue.Count > 0)
            {
                data = queue.Dequeue();
                Console.Write(data.Value);

                if (data.left != null)
                {
                    queue.Enqueue(data.left);
                }
                if (data.right != null)
                {
                    queue.Enqueue(data.right);
                }
            }
        }        
    }
}

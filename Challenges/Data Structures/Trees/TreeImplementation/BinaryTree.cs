using System;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }
   
        public BinaryTree(int value)
        {
            Root = new Node(value);

        }

        public void PreOrder(Node node)
        {
            if (node == null) return;
            Console.WriteLine(node.Value);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(Node node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.WriteLine(node.Value);
            InOrder(node.Right);
        }

        public void PostOrder(Node node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine(node.Value);
        }

        public void Print()
        {
            Print(Root, "", true);
        }

        private void Print(Node node, string indent, bool isLast)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (isLast)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "| ";
                }

                Console.WriteLine(node.Value);

                Print(node.Left, indent, node.Right == null);
                Print(node.Right, indent, true);
            }
        }
    }
}

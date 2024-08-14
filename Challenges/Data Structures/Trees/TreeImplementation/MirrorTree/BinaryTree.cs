using System;
using System.Collections.Generic;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(int value)
        {
            Root = new Node(value);
        }

        // Method to convert the binary tree into its mirror
        public void Mirror()
        {
            MirrorTree(Root);
        }

        private void MirrorTree(Node node)
        {
            if (node == null)
                return;

            // Recursively call MirrorTree on left and right subtrees
            MirrorTree(node.Left);
            MirrorTree(node.Right);

            // Swap left and right children
            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }

        // InOrder Traversal Method
        public List<int> InorderTraversal()
        {
            return InOrderTraversal(Root);
        }

        private List<int> InOrderTraversal(Node node)
        {
            List<int> result = new List<int>();

            if (node == null)
                return result;

            result.AddRange(InOrderTraversal(node.Left));
            result.Add(node.Value);
            result.AddRange(InOrderTraversal(node.Right));

            return result;
        }

        // Print tree structure
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

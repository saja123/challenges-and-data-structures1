using System;
using System.Collections.Generic;

namespace TreeImplementation.SecondMaxValue
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

        public int? FindSecondMax()
{
    if (Root == null)
        throw new InvalidOperationException("The tree is empty.");

    int? max = null;
    int? secondMax = null;

    void Traverse(Node node)
    {
        if (node == null)
            return;

        if (max == null || node.Value > max)
        {
            secondMax = max;
            max = node.Value;
        }
        else if (node.Value < max && (secondMax == null || node.Value > secondMax))
        {
            secondMax = node.Value;
        }

        Traverse(node.Left);
        Traverse(node.Right);
    }

    Traverse(Root);

    if (secondMax == null)
        throw new InvalidOperationException("There is no second maximum value in the tree.");

    return secondMax;
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
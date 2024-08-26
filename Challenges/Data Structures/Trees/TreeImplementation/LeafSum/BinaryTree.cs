using System;
using System.Collections.Generic;
public class BinaryTree
{
    public Node Root;
    

    public List<int> LargestValueEachLevel()
    {
        List<int> largestValues = new List<int>();
        if (Root == null) return largestValues;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            int maxAtLevel = int.MinValue;

            for (int i = 0; i < levelSize; i++)
            {
                Node current = queue.Dequeue();
                if (current.Value > maxAtLevel)
                {
                    maxAtLevel = current.Value;
                }

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            largestValues.Add(maxAtLevel);
        }

        return largestValues;
    }
}


//using System;
//using System.Collections.Generic;

//namespace TreeImplementation.LeafSum
//{
//    public class BinaryTree
//    {
//        public Node Root { get; set; }

//        public BinaryTree()
//        {
//            Root = null;
//        }

//        public BinaryTree(int value)
//        {
//            Root = new Node(value);
//        }

//        public int SumOfLeafNodes()
//        {
//            return CalculateLeafSum(Root);
//        }

//        private int CalculateLeafSum(Node node)
//        {
//            if (node == null)
//                return 0;

//            if (node.Left == null && node.Right == null)
//                return node.Value;

//            int leftSum = CalculateLeafSum(node.Left);
//            int rightSum = CalculateLeafSum(node.Right);

//            return leftSum + rightSum;
//        }

//        public void Print()
//        {
//            Print(Root, "", true);
//        }

//        private void Print(Node node, string indent, bool isLast)
//        {
//            if (node != null)
//            {
//                Console.Write(indent);
//                if (isLast)
//                {
//                    Console.Write("└─");
//                    indent += "  ";
//                }
//                else
//                {
//                    Console.Write("├─");
//                    indent += "| ";
//                }

//                Console.WriteLine(node.Value);

//                Print(node.Left, indent, node.Right == null);
//                Print(node.Right, indent, true);
//            }
//        }
//    }
//}

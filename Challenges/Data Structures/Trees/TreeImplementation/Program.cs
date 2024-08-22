﻿using System;
using TreeImplementation.LeafSum;


namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(9);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(12);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(17);
            Btree.Root.Right.Right = new Node(23);
            Btree.Root.Left.Left.Right = new Node(4);

            Console.WriteLine("Tree Structure:");
            Btree.Print();

            int leafSum = Btree.SumOfLeafNodes();
            Console.WriteLine($"\nThe sum of all leaf nodes in the tree is: {leafSum}");
            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(10);
            //Btree.Root.Left = new Node(5);
            //Btree.Root.Right = new Node(20);
            //Btree.Root.Left.Left = new Node(3);
            //Btree.Root.Left.Right = new Node(7);
            //Btree.Root.Right.Left = new Node(15);
            //Btree.Root.Right.Right = new Node(25);

            //Console.WriteLine("Tree Structure:");
            //Btree.Print();

            //int? secondMax = Btree.FindSecondMax();
            //Console.WriteLine($"\nThe second maximum value in the tree is: {secondMax}");
        }
    }
}


    //BinaryTree Btree = new BinaryTree();
    //Btree.Root = new Node(4);
    //Btree.Root.Left = new Node(8);
    //Btree.Root.Right = new Node(7);
    //Btree.Root.Left.Left = new Node(12);
    //Btree.Root.Left.Right = new Node(9);

    //Console.WriteLine("Original Tree:");
    //Btree.Print();

    //var originalInorder = Btree.InorderTraversal();
    //Console.WriteLine("\nOriginal InOrder Traversal:");
    //Console.WriteLine("[" + string.Join(", ", originalInorder) + "]");


    //Btree.Mirror();

    //Console.WriteLine("\nMirrored Tree:");
    //Btree.Print();

    //var mirroredInorder = Btree.InorderTraversal();
    //Console.WriteLine("\nMirrored InOrder Traversal:");
    //Console.WriteLine("[" + string.Join(", ", mirroredInorder) + "]");








//using System;
//using TreeImplementation.MirrorTree;

//namespace TreeImplementation
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {

//            BinarySearchTree bst = new BinarySearchTree(11);

//            bst.Add(10);
//            bst.Add(5);
//            bst.Add(15);
//            bst.Add(7);

//            Console.WriteLine("Tree before removal:");
//            bst.Print(); 

//            bool contains7 = bst.Contains(7); 
//            Console.WriteLine($"Contains 7: {contains7}");

//            bst.Remove(5);

//            Console.WriteLine("Tree after removal of 5:");
//            bst.Print();

//            bool contains5 = bst.Contains(5);
//            Console.WriteLine($"Contains 5 after removal: {contains5}");
//            Console.WriteLine();
//            Console.WriteLine();
//            BinaryTree tree = new BinaryTree(1);
//            tree.Root.Left = new Node(2);
//            tree.Root.Right = new Node(3);
//            tree.Root.Left.Left = new Node(4);
//            tree.Root.Left.Right = new Node(5);
//            tree.Root.Right.Left = new Node(6);
//            tree.Root.Right.Right = new Node(7);

//            Console.WriteLine("PreOrder Traversal:");
//            tree.PreOrder(tree.Root);

//            Console.WriteLine("\nInOrder Traversal:");
//            tree.InOrder(tree.Root);

//            Console.WriteLine("\nPostOrder Traversal:");
//            tree.PostOrder(tree.Root);

//            Console.WriteLine("\nTree Structure:");
//            tree.Print();
//        }
//    }
//}

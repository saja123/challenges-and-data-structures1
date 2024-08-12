﻿using System;

namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            BinarySearchTree bst = new BinarySearchTree(11);

            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            Console.WriteLine("Tree before removal:");
            bst.Print(); 

            bool contains7 = bst.Contains(7); 
            Console.WriteLine($"Contains 7: {contains7}");

            bst.Remove(5);

            Console.WriteLine("Tree after removal of 5:");
            bst.Print();

            bool contains5 = bst.Contains(5);
            Console.WriteLine($"Contains 5 after removal: {contains5}");
            Console.WriteLine();
            Console.WriteLine();
            BinaryTree tree = new BinaryTree(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            Console.WriteLine("PreOrder Traversal:");
            tree.PreOrder(tree.Root);

            Console.WriteLine("\nInOrder Traversal:");
            tree.InOrder(tree.Root);

            Console.WriteLine("\nPostOrder Traversal:");
            tree.PostOrder(tree.Root);

            Console.WriteLine("\nTree Structure:");
            tree.Print();
        }
    }
}
using challenges_and_data_structures1;
using StackAndQueue.DeleteMiddleElement;
using System;
using System.Collections.Generic;

namespace challenges_and_data_structures1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var minStack = new MinStack();

            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(5);
            linkedList.AddNode(6);

            Console.WriteLine("Original List:");
            linkedList.Display();

            int k = 2;
            Console.WriteLine($"\nRotating the list to the left by {k} positions:");
            linkedList.RotateLeft(k);

            linkedList.Display();

            k = 3;
            Console.WriteLine($"\nRotating the list to the left by {k} positions:");
            linkedList.RotateLeft(k);

            linkedList.Display();
            Console.ReadKey();
        }
    }
}
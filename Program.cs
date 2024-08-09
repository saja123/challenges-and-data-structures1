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

            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            Console.Write("Current Stack: ");
            minStack.PrintStack();

            Console.WriteLine($"Minimum Element: {minStack.GetMin()}");

            Console.WriteLine($"Popped Element: {minStack.Pop()}");

            Console.Write("Stack after Pop: ");
            minStack.PrintStack();

            Console.WriteLine($"New Minimum Element: {minStack.GetMin()}");

            Console.WriteLine($"Top Element: {minStack.Top()}");

            minStack.Push(2);
            Console.Write("Stack after Push 2: ");
            minStack.PrintStack();

            Console.WriteLine($"New Minimum Element: {minStack.GetMin()}");

            Console.WriteLine($"Is Stack Empty: {minStack.IsEmpty()}");
        }
    }
}
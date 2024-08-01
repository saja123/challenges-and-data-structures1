using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures1
{
    public class Stack
    {
        private LinkedList linke;

        public Stack()
        {
            linke = new LinkedList();
        }

        public void Push(int data)
        {
            linke.AddToHead(data);
        }

        public int Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return linke.RemoveHead();
        }

        public int Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return linke.head.Data;
        }

        public bool IsEmpty()
        {
            return linke.head == null;
        }
        public void PrintStack()
        {
           linke.PrintList();
        }

        public void ReverseStack()
        {
            if (IsEmpty()) return;
            Queue queue = new Queue();
            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }
            while (!queue.IsEmpty())
            {
                Push(queue.Dequeue());
            }
        }
    }

}

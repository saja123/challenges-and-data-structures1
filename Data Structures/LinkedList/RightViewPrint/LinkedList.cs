using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTest
{
    public class LinkedList
    {
        private Node head;
        public LinkedList()
        {
            head = null;
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                newNode = head;
            }
            else
            {
                newNode.Next = head;
            }
            head = newNode;
        }
        public void AddLast(int data)
        {
            Node node2 = new Node(data);
            if (head == null)
            {
                head = node2;
            }
            else
            {
                Node Current = head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = node2;
            }
        }
        public void AddMiddle(int data)
        {
            Node node3 = new Node(data);
            if (head == null)
            {
                head = node3;
            }
            else
            {
                int size = 0;
                Node current2 = head;
                while (current2 != null)
                {
                    size++;
                    current2 = current2.Next;
                }
                int middle = size / 2;


            }
        }
    }
}




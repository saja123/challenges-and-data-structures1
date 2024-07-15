namespace challenges_and_data_structures1
{
    public class LinkedList
    {
        public Node head;

        public void AddNode(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool Includes(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (head == null) Console.WriteLine("List is empty");

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            Node previous = null;
            while (current != null && current.Data != data)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Data not found in list");
            }

            previous.Next = current.Next;
        }

        public void PrintList()
        {
            Node current = head;
            if (current == null)
                Console.WriteLine("The List is empty");
            else
            {
                Console.Write("List: ");
                while (current != null)//
                {

                    Console.Write($"{current.Data} --> ");
                    current = current.Next;
                }
                Console.WriteLine("Null");

            }
        }
        public void RemoveDuplicate()
        {
            Node current = head;
            while (current != null)
            {
                Node index = current;
                while (index.Next != null)
                {
                    if (current.Data == index.Next.Data)
                    {
                        index.Next = index.Next.Next;
                    }
                    else
                    {
                        index = index.Next;
                    }
                }
                current = current.Next;
            }
        }

    }
}


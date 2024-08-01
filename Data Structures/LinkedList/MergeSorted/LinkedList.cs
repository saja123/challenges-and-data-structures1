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

        public int RemoveHead()
        {
            if (head == null) Console.WriteLine("The List is Empty");

            Node node = head;
            head = node.Next;
            node.Next = null;
            return node.Data;

        }
        public void Remove(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

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

            if (current == null)
            {
                Console.WriteLine("Data not found in list");
                return;
            }

            previous.Next = current.Next;
        }

        public void AddToHead(int newValue)
        {
            Node node = new Node(newValue);
            if (head == null) head = node;
            else
            {
                node.Next = head;
                head = node;
            }
        }

        public void PrintList()
            {
                Node current = head;
                if (current == null)
                {
                    Console.WriteLine("The List is empty");
                }
                else
                {
                    Console.Write("Head: ");
                    while (current != null)
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

            public LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
            {
                Node current1 = list1.head;
                Node current2 = list2.head;

                LinkedList mergedList = new LinkedList();

                while (current1 != null && current2 != null)
                {
                    if (current1.Data <= current2.Data)
                    {
                        mergedList.AddNode(current1.Data);
                        current1 = current1.Next;
                    }
                    else
                    {
                        mergedList.AddNode(current2.Data);
                        current2 = current2.Next;
                    }
                }

                while (current1 != null)
                {
                    mergedList.AddNode(current1.Data);
                    current1 = current1.Next;
                }

                while (current2 != null)
                {
                    mergedList.AddNode(current2.Data);
                    current2 = current2.Next;
                }

                return mergedList;
            }
        }
    }



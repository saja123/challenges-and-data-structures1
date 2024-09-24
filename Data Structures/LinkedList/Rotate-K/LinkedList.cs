namespace challenges_and_data_structures1
{
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;
        }

        
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

      
        public void Display()
        {
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("The List is empty");
            }
            else
            {
                while (current != null)
                {
                    Console.Write($"{current.Data} --> ");
                    current = current.Next;
                }
                Console.WriteLine("Null");
            }
        }

       
        public void RotateLeft(int k)
        {
            if (head == null || k == 0)
            {
                return;
            }

           
            int length = 1;
            Node tail = head;
            while (tail.Next != null)
            {
                tail = tail.Next;
                length++;
            }

            
            k = k % length;
            if (k == 0) return;

         
            Node current = head;
            for (int i = 1; i < k; i++)
            {
                current = current.Next;
            }

           
            Node newHead = current.Next;
            current.Next = null;
            tail.Next = head;
            head = newHead;
        }
    }
}

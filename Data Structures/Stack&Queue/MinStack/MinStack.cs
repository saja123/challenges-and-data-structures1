using challenges_and_data_structures1;

public class MinStack
{
    private LinkedList mainStack;
    private LinkedList minStack;

    public MinStack()
    {
        mainStack = new LinkedList();
        minStack = new LinkedList();
    }

    public void Push(int data)
    {
        mainStack.AddToHead(data);

        if (minStack.head == null || data <= minStack.head.Data)
        {
            minStack.AddToHead(data);
        }
    }

    public int Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
        int removedValue = mainStack.RemoveHead();

        if (removedValue == minStack.head.Data)
        {
            minStack.RemoveHead();
        }

        return removedValue;
    }

    public int Top()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
        return mainStack.head.Data;
    }

    public bool IsEmpty()
    {
        return mainStack.head == null;
    }

    public int GetMin()
    {
        if (minStack.head == null) throw new InvalidOperationException("Stack is empty");
        return minStack.head.Data;
    }

    public void PrintStack()
    {
        Console.Write("Top -> ");
        Node current = mainStack.head;
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("Null");
    }
}


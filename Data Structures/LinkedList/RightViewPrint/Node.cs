using System;
namespace challenges_and_data_structures1
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

    }
    //public class Node
    //{
    //    public int Data { get; set; }
    //    public Node Next { get; set; }
    //    public Node(int data)
    //    {
    //        Data = data; 
    //        Next = null;
    //    }
    //}
}

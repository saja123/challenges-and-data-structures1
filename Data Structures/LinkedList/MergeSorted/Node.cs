﻿using System;
namespace challenges_and_data_structures1
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data; 
            Next = null;
        }
    }
}

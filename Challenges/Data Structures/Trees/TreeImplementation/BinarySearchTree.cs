namespace TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(int value) : base(value)
        {
        }

        public void Add(int value)
        {
            Add(Root, value);
        }

        private void Add(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    Add(node.Left, value);
                }
            }
            else if (value > node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Add(node.Right, value);
                }
            }
        }

        public bool Contains(int value)
        {
            return Contains(Root, value);
        }

        private bool Contains(Node node, int value)
        {
            if (node == null)
                return false;

            if (value < node.Value)
                return Contains(node.Left, value);
            else if (value > node.Value)
                return Contains(node.Right, value);
            else
                return true; 
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }

        private Node Remove(Node node, int value)
        {
            if (node == null)
                return node;

            if (value < node.Value)
            {
                node.Left = Remove(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Remove(node.Right, value);
            }
            else
            {
                if (node.Left == null && node.Right == null)
                {
                    return null;
                }
                if (node.Left == null)
                {
                    return node.Right;
                }
                if (node.Right == null)
                {
                    return node.Left;
                }

                node.Value = MinValue(node.Right);
                node.Right = Remove(node.Right, node.Value);
            }

            return node;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
        
    }
}

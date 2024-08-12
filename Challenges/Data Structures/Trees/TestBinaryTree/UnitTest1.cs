using TreeImplementation;
using Xunit;
using System.Collections.Generic;

namespace TreeImplementation.Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void PreOrder_ShouldReturnNodesInPreOrder()
        {
            // Arrange
            var tree = new BinaryTree(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            var expectedOrder = new List<int> { 1, 2, 4, 5, 3 };
            var actualOrder = new List<int>();

            // Act
            tree.PreOrder(tree.Root);
            CaptureOutput(tree.PreOrder, tree.Root, actualOrder);

            // Assert
            Assert.Equal(expectedOrder, actualOrder);
        }

        [Fact]
        public void InOrder_ShouldReturnNodesInInOrder()
        {
            // Arrange
            var tree = new BinaryTree(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            var expectedOrder = new List<int> { 4, 2, 5, 1, 3 };
            var actualOrder = new List<int>();

            // Act
            CaptureOutput(tree.InOrder, tree.Root, actualOrder);

            // Assert
            Assert.Equal(expectedOrder, actualOrder);
        }

        [Fact]
        public void PostOrder_ShouldReturnNodesInPostOrder()
        {
            // Arrange
            var tree = new BinaryTree(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            var expectedOrder = new List<int> { 4, 5, 2, 3, 1 };
            var actualOrder = new List<int>();

            // Act
            CaptureOutput(tree.PostOrder, tree.Root, actualOrder);

            // Assert
            Assert.Equal(expectedOrder, actualOrder);
        }

        private void CaptureOutput(Action<Node> traversalMethod, Node node, List<int> output)
        {
            // Temporarily redirect the console output
            var originalConsoleOut = Console.Out;
            try
            {
                using (var writer = new StringWriter())
                {
                    Console.SetOut(writer);
                    traversalMethod(node);
                    writer.Flush();
                    var lines = writer.ToString().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    foreach (var line in lines)
                    {
                        if (int.TryParse(line, out int value))
                        {
                            output.Add(value);
                        }
                    }
                }
            }
            finally
            {
                // Restore the original console output
                Console.SetOut(originalConsoleOut);
            }
        }
    }
}

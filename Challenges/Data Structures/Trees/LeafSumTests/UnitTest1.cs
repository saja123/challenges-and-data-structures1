using System;
using TreeImplementation.LeafSum;
using Xunit;

namespace TreeImplementation.Tests
{
    public class LeafSumTests
    {
        [Fact]
        public void TestSumOfLeafNodes_WithPositiveValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(9);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(12);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(17);
            Btree.Root.Right.Right = new Node(23);
            Btree.Root.Left.Left.Right = new Node(4);

            // Act
            int result = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(51, result);  
        }

        [Fact]
        public void TestSumOfLeafNodes_WithNegativeValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(-9);
            Btree.Root.Left = new Node(-8);
            Btree.Root.Right = new Node(-12);
            Btree.Root.Left.Left = new Node(-3);
            Btree.Root.Left.Right = new Node(-7);
            Btree.Root.Right.Left = new Node(-17);
            Btree.Root.Right.Right = new Node(-23);
            Btree.Root.Left.Left.Right = new Node(-4);

            // Act
            int result = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(-51, result);  
        }

        [Fact]
        public void TestSumOfLeafNodes_WithSingleNode()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);

            // Act
            int result = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(10, result);  
        }

        [Fact]
        public void TestSumOfLeafNodes_WithEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act
            int result = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(0, result);  
        }
    }
}

using System;
using System.Collections.Generic;
using Xunit;
using TreeImplementation.SecondMaxValue;
using TreeImplementation;

namespace SecondMaxValueTests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void TestFindSecondMax()
        {
            // Arrange
            var tree = new BinaryTree(10);
            tree.Root.Left = new Node(5);
            tree.Root.Right = new Node(20);
            tree.Root.Left.Left = new Node(3);
            tree.Root.Left.Right = new Node(7);
            tree.Root.Right.Left = new Node(15);
            tree.Root.Right.Right = new Node(25);

            // Act
            int? secondMax = tree.FindSecondMax();

            // Assert
            Assert.Equal(20, secondMax);
        }

        [Fact]
        public void TestTreeWithFewerThanTwoUniqueValues()
        {
            // Arrange
            var tree = new BinaryTree(1);
            tree.Root.Left = new Node(1);
            tree.Root.Right = new Node(1);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => tree.FindSecondMax());
        }

        [Fact]
        public void TestTreeWithNegativeValues()
        {
            // Arrange
            var tree = new BinaryTree(-1);
            tree.Root.Left = new Node(-5);
            tree.Root.Right = new Node(-10);
            tree.Root.Left.Left = new Node(-20);
            tree.Root.Left.Right = new Node(-15);
            tree.Root.Right.Left = new Node(-7);
            tree.Root.Right.Right = new Node(-30);

            // Act
            int? secondMax = tree.FindSecondMax();

            // Assert
            Assert.Equal(-5, secondMax);
        }
    }
}

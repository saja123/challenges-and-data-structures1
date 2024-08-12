using TreeImplementation;
using Xunit;
using System;
using System.IO;

namespace TreeImplementation.Tests
{

    public class BinarySearchTreeTests
    {
        [Fact]
        public void Add_ShouldAddNodesInCorrectOrder()
        {
            // Arrange
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);

            // Act & Assert
            Assert.Equal(5, bst.Root.Left.Value);
            Assert.Equal(15, bst.Root.Right.Value);
            Assert.Equal(2, bst.Root.Left.Left.Value);
            Assert.Equal(7, bst.Root.Left.Right.Value);
        }

        [Fact]
        public void Contains_ShouldReturnTrueIfNodeExists()
        {
            // Arrange
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);

            // Act & Assert
            Assert.True(bst.Contains(7));
            Assert.False(bst.Contains(20));
        }

        [Fact]
        public void Remove_ShouldRemoveNodeAndMaintainBSTProperties()
        {
            // Arrange
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);

            // Act
            bst.Remove(5);

            // Assert
            Assert.False(bst.Contains(5));
            Assert.True(bst.Contains(2));
            Assert.True(bst.Contains(7));
            
        }
    }
    

}

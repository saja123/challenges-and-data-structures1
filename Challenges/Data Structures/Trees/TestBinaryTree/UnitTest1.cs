//using System.Collections.Generic;
//using Xunit;
//using TreeImplementation;

//namespace TreeImplementation.Tests
//{
//    public class BinaryTreeTests
//    {
//        [Fact]
//        public void TestMirrorTree()
//        {
//            BinaryTree tree = new BinaryTree(4);
//            tree.Root.Left = new Node(8);
//            tree.Root.Right = new Node(7);
//            tree.Root.Left.Left = new Node(12);
//            tree.Root.Left.Right = new Node(9);

//            List<int> originalInorder = tree.InorderTraversal();
//            Assert.Equal(new List<int> { 12, 8, 9, 4, 7 }, originalInorder);

//            tree.Mirror();

//            List<int> mirroredInorder = tree.InorderTraversal();
//            Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
//        }

//        [Fact]
//        public void TestSingleNodeTree()
//        {
//            BinaryTree tree = new BinaryTree(1);

//            List<int> originalInorder = tree.InorderTraversal();
//            Assert.Equal(new List<int> { 1 }, originalInorder);

//            tree.Mirror();

//            List<int> mirroredInorder = tree.InorderTraversal();
//            Assert.Equal(new List<int> { 1 }, mirroredInorder);
//        }

//        [Fact]
//        public void TestEmptyTree()
//        {
//            BinaryTree tree = new BinaryTree();

//            List<int> originalInorder = tree.InorderTraversal();
//            Assert.Empty(originalInorder);

//            tree.Mirror();

//            List<int> mirroredInorder = tree.InorderTraversal();
//            Assert.Empty(mirroredInorder);
//        }
//    }
//}

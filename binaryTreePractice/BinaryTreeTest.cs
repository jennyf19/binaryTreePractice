using System;
using System.Linq;
using Xunit;

namespace binaryTreePractice
{
    public class BinaryTreeTest
    {
        [Fact]
        public void TestMethod1()
        {
            var quickSort = new BinaryTree();

            Assert.Equal(quickSort.Size(), 0);
        }

        [Fact]
        public void TestMethod2()
        {
            var treeSize = new BinaryTree();

            Assert.Equal(treeSize.Size(), 0);

        }
       
        [Fact]
        public void TestMethod3()
        {
            var treeInsert = new BinaryTree();

            Assert.Equal(treeInsert.GetHashCode(), 0);
        }

        [Fact]
        public void TestMethod4()
        {
            var treeDelete = new BinaryTree();

            Assert.Equal(treeDelete.GetHashCode(), 0);
        }

        [Fact]
        public void TestMethod5()
        {
            var treeFind = new BinaryTree();

            Assert.Equal(treeFind.GetHashCode(), 0);
        }

        [Fact]
        public void TestMethod6()
        {
            var nodeTrack = new BinaryTree();

            Assert.Equal(nodeTrack.GetHashCode(), 0);
        }
    }
}

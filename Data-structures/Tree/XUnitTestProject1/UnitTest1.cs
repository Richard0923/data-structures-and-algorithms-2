using System;
using Xunit;
using Tree.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyTreeTest()
        {
            Trees testy = new Trees();
            Assert.NotNull(testy);
        }

        [Fact]
        public void SingleRootNodeTest()
        {
            Node node = new Node(20);
            Trees testy = new Trees(node);
            Assert.Equal(node, testy.Root);
        }
    }
}

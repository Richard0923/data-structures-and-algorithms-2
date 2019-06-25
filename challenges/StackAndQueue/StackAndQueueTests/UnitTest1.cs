using System;
using Xunit;
using StackAndQueue.Classes;


namespace StackAndQueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void PushIntoStackTest()
        {
            Stack<int> mystack = new Stack<int>(7);
            mystack.Push(11);
            Assert.Equal(11, mystack.Peek());
        }
    }
}

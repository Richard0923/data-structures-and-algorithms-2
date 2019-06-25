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

        [Fact]
        public void PushMultipleValuesTest()
        {
            Stack<int> mystack = new Stack<int>(7);
            mystack.Push(5);
            mystack.Push(19);
            mystack.Push(52);
            Assert.Equal(52, mystack.Peek());
        }

        [Fact]
        public void PopOutOfStackTest()
        {
            Stack<int> mystack = new Stack<int>(7);
            mystack.Push(5);
            Assert.Equal(5, mystack.Pop());
        }

        [Fact]
        public void EmptyAStackTest()
        {
            Stack<int> mystack = new Stack<int>(7);
            mystack.Push(5);
            mystack.Pop();
            mystack.Pop();
            Assert.Null(mystack.Top);
        }

        [Fact]
        public void PeekNextNodeTest()
        {
            Stack<int> mystack = new Stack<int>(7);
            mystack.Push(5);
            mystack.Push(19);
            mystack.Push(52);
            Assert.Equal(19, mystack.Top.Next.Value);
        }

        [Fact]
        public void EmptyStacktest()
        {
            Stack<string> mystack = new Stack<string>();

            Assert.Null(mystack.Top.Value);

        }
    }
}

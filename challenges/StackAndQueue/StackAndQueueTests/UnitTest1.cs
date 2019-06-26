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
            Stack<int> mystack = new Stack<int>();

            Assert.Throws<NullReferenceException>(() => mystack.Peek());
        }

        [Fact]
        public void EnqueueTest()
        {
            Queue<string> myQueue = new Queue<string>("test");
            myQueue.Enqueue("test2");
            Assert.Equal("test2", myQueue.Rear.Value);
        }

        [Fact]
        public void EnqueueMulitpleValueTest()
        {
            Queue<int> myQueue = new Queue<int>(7);
            myQueue.Enqueue(14);
            myQueue.Enqueue(19);
            myQueue.Enqueue(123);
            Assert.Equal(123, myQueue.Rear.Value);
        }

        [Fact]
        public void DequeueTest()
        {
            Queue<int> myQueue = new Queue<int>(22);
            myQueue.Enqueue(33);
            myQueue.Enqueue(67);
            myQueue.Enqueue(77);

            Assert.Equal(22, myQueue.Dequeue());
        }

        [Fact]
        public  void PeekQueueTest()
        {
            Queue<int> myQueue = new Queue<int>(22);
            myQueue.Enqueue(33);
            myQueue.Enqueue(67);
            myQueue.Enqueue(77);

            Assert.Equal(22, myQueue.Peek());
        }

        [Fact]
        public void EmptyQueueTest()
        {
            Queue<int> myQueue = new Queue<int>(22);
            myQueue.Enqueue(33);
            myQueue.Enqueue(67);
            Assert.Equal(0, myQueue.Front.Value);

        }
    }
}

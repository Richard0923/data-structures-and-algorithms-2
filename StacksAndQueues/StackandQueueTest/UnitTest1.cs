using System;
using Xunit;
using StacksAndQueues.Classes;
using System.Collections.Generic;
using System.Collections;

namespace StackandQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Stack myStack = new Stack(5);
            Assert.NotEmpty(myStack);
        }
    }
}

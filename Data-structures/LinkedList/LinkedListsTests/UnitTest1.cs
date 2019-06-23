using Xunit;
using LinkedList.Classes;
using System;


namespace LinkedListsTests
{
    public class UnitTest1
    {
        
        [Fact]
        
        public void IncludesValueInLListTest()
        {
            LList lltest = new LList(5);
            lltest.Insert(6);

            Assert.True(lltest.Inculdes(5));
        }

        [Fact]
        public void AppendTotheendTest()
        {
            LList lltest = new LList(5);
            lltest.Append(6);

            Assert.True(lltest.Inculdes(6));
        }

        [Fact]
        public void InsertBeforeTest()
        {
            LList lltest = new LList(5);
            lltest.Append(6);
            lltest.Append(13);
            lltest.Append(15);
            lltest.InsertBefore(6, 15);

            Assert.True(lltest.Inculdes(6));
        }

    }
}

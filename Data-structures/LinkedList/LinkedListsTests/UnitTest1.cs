using Xunit;
using LinkedList.Classes;


namespace LinkedListsTests
{
    public class UnitTest1
    {
        
        [Fact]
        public void IncludesValueInLListTest()
        {
            LList lltest = new LList(5);

            Assert.True(lltest.Inculdes(5));
        }
    }
}

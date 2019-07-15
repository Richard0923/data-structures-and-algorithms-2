using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void InsertionSortTest()
        {
            int[] unsorted = { 20, 47, 2, 7, 19 };
            int[] sorted = { 2, 7, 19, 20, 47 };

            Assert.Equal(sorted, InsertionSort(unsorted));
        }
    }
}

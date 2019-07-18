using System;
using Xunit;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void QuickSortTest()
        {
            int[] unsorted = { 29, 54, 10, 78, 29, 1 };
            int[] sorted = { 1, 10, 29, 29, 54, 78 };

            QuickSort.Program.QuickSort(unsorted, 0, 5);

            Assert.Equal(sorted, unsorted);
        }
    }
}

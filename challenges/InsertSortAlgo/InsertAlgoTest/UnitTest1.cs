using System;
using Xunit;


namespace InsertAlgoTest
{
    public class UnitTest1
    {
        [Fact]
        public void InsertionSortTest()
        {
            int[] unsorted = { 20, 47, 2, 7, 19 };
            int[] sorted = { 2, 7, 19, 20, 47 };

            int[] NewArray = InsertSortAlgo.Program.InsertionSort(unsorted);

            Assert.Equal(sorted, NewArray);
        }
    }
}

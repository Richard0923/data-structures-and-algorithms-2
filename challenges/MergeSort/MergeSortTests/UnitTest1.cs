using System;
using Xunit;
using MergeSort;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void MergeSortTest()
        {
            int[] testArray = { 5, 23, 45, 99, 10, 77 };

            int[] sortedArray = { 5, 10, 23, 45, 77, 99 };
            
            int[] newArray = Program.MergeSort(testArray);

            Assert.Equal(sortedArray, newArray);
        }
    }
}

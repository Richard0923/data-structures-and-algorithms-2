using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 8, 15, 16, 23, 42 };
            int searchkey = 15;
            int answer = BinarySearch(array, searchkey);
        }

        static int BinarySearch(int[] arr, int searchkey)
        {
            int left = 0;
            int right = arr.Length;
            int middle = left + right / 2;

            while (left <= right)
            {
                if (arr[middle] < searchkey)
                {
                    left = middle + 1;
                }
                else if(arr[middle] > searchkey)
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            Console.WriteLine(middle);
            return middle;
        }
    }
}

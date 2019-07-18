using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(array, left, right);

                QuickSort(array, left, position - 1);
                QuickSort(array, position + 1, right);
            }
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int low = left - 1;
            for (int i = left; i < right; i++)
            {
                if(arr[i]<= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);

            return low + 1;
        }

        public static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}

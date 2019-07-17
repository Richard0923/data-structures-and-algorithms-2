using System;


namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] testArray = { 5, 78, 23, 45, 10, 77};
            MergeSort(testArray);
        }

        public static int[] MergeSort(int[] array)
        {
            int n = array.Length;
            
            if(n > 1)
            {
                int mid = n / 2;

                int[] left = new int[0 + mid];
                int[] right = new int[n - mid];

                MergeSort(left);//maybe set as variables 
                MergeSort(right);
                int[] results = Merge(left, right, array);
            }
                return array;
        }

        public static int[] Merge(int[] left, int[] right, int[] array)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while(i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            if(i == left.Length)
            {
                right.CopyTo(array, left.Length);
            }
            else
            {
                left.CopyTo(array, 0);
            }
            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int[] testArray = { 5, 78, 23, 45};
            int[] sortedtest = MergeSort(testArray);
            Console.WriteLine("Hello World!");
        }

        public static int[] MergeSort(int[] array)
        {
            int n = array.Length;
            
            if(n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < mid; i++)
                {
                    left[i] = array[i];
                }

                int x = 0;
                for (int j = mid; j < array.Length; j++)
                {
                    right[x] = array[j];
                    x++;
                }
                
                MergeSort(left);

                MergeSort(right);
                Merge(left, right, array);
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
                array[k] = right[j];
            }
            else
            {
                array[k] = left[i];
            }
            return array;
        }
    }
}

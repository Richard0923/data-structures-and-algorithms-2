using System;


namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int[] testArray = { 5, 78, 23, 45, 10, 77};
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
                int[] results = Merge(left, right, array);
                return results;
            }
            return null;

        }

        public static int[] Merge(int[] left, int[] right, int[] array)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int[] results = new int[right.Length + left.Length];

            while(i < left.Length && j < right.Length)
            {

                if(left[i] <= right[j])
                {
                    results[k] = left[i];
                    i++;
                }
                else
                {
                    results[k] = right[j];
                    j++;
                    
                }
                k++;
            }
            return results;
        }
    }
}

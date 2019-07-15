using System;
using System.Collections.Generic;
using System.Text;

namespace InsertSort
{
    class InsertionAlgo
    {
        //needs to return the array 
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int temp = array[i];

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = temp;
            }
            return array;
        }
    }
}

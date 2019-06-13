using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 2, 3, 5, 9, 4 };
            int value = 7;
            insertShiftArray(arr, value);
        }

        static int[] insertShiftArray(int[] arr, int value)
        {
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i >= (arr.Length) / 2 && i < arr.Length + 1)
                {
                    i = value;
                }
            }

            int[] newArray = arr;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.ReadLine();
            }
            return newArray;
        }
    }
}

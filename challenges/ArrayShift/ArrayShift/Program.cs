using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 9, 4 };
            int value = 7;
            Console.WriteLine(String.Join(", ", insertShiftArray(arr, value)));
            Console.ReadLine();
        }

        static int[] insertShiftArray(int[] arr, int value)
        {
            //Local variables for method 
            int mid = arr.Length /2;
            int[] newArr = new int[arr.Length + 1];
            int counter = 0;

            for(int i = 0; i < newArr.Length; i++)
            {
                if(i == mid)
                {
                    newArr[i] = value;
                }
                else
                {
                    newArr[i] = arr[counter];
                    counter++;
                }
            }

            return newArr;

        }
    }
}

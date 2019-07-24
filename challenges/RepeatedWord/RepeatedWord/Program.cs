using System;

namespace RepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void RepeatedWord(string inputString)
        {
            bool space = true;
            int k = 0;
            int i = 0;
            string[] words = new string[inputString.Length];
            //might need another array

            while(i < inputString.Length)
            {
                if(inputString[i] == ' ')
                {
                    space = true;
                    i++;
                }
                else if(space == true) 
                {
                    space = false;
                    //add to the array
                    words[k] = inputString[i];
                    
                    //need an array or create other method 
                }
                
            }

        }
    }
}

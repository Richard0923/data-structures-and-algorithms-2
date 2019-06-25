using System;

namespace LLMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static LinkedList MergeLists(LinkedList ll1, LinkedList ll2)
        {
            Node C1 = ll1.Head;
            Node C2 = ll2.Head;
            Node temp = null;

            while (C1 != null && C2 != null)
            {
                if (C1 != null)
                {
                    temp = C1.Next;
                    C1.Next = C2;
                    C1 = temp;
                }

                if (C2 != null)
                {
                    temp = C2.Next;
                    if (C1 != null)
                    {
                        C2.Next = C1;

                    }
                }
            }
        }
    }

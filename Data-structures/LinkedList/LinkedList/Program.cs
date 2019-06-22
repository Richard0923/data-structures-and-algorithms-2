using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            PopulateList();
        }

        static void PopulateList()
        {
            LList list = new LList(11);

            list.Insert(56);
            list.Insert(42);
            list.Insert(23);
            list.Insert(72);
            list.Insert(11);

            list.Print();
            
            list.Inculdes(56);
            list.Inculdes(77);
            Console.ReadLine();
        }

    }
}

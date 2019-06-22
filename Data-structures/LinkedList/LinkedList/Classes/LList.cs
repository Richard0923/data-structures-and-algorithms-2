using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Head { get; set; }

       
        public LList(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Creates a new node and pass it a value lastly adds that node to the head 
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            //need to check that everythong works
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        /// <summary>
        /// prints out the Linked List 
        /// </summary>
        public void Print()
        {
            Node current = Head;

            while(current != null)
            {
                Console.Write($"{current.Value} => ");
                current = current.Next;
            }

            Console.Write("null");
            Console.Read();
        }

        public bool Inculdes(int value)
        { //need tests
            Node current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    Console.Write($"True it includes {value}");
                    return true;
                }
                
               current = current.Next;
            }
            return false;
        }

        public static void PopulateList()
        {
            LList list = new LList(10);

            list.Insert(56);
            list.Insert(42);
            list.Insert(23);
            list.Insert(72);
            list.Insert(11);

            list.Print();
            Console.WriteLine("\n");
        }
    }
}

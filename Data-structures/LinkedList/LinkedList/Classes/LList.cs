using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }

        public LList()
        {

        }

        public LList(int value)
        {
            Node node = new Node(value);
        }

        /// <summary>
        /// creates a new node and adds that node to the head 
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            //need to check that everythong works
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
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
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    Console.Write("True");
                    return true;
                }
                //dont know what this error is need to find out 
                current.Next();
            }

            return false;
        }
    }
}

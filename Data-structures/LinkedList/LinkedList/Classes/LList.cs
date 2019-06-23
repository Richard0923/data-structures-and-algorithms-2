using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        

       
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

        /// <summary>
        /// Adds a new node to the end of the list 
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Node newvalue = new Node(value);
            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newvalue;
        }

        /// <summary>
        /// Inserts a new node before the node that is equal to the value you give it 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
            while(Current.Next != null)
            {
                if(Current.Next.Value == value)
                {
                    Node tempNode = new Node(value);
                    Current.Next = tempNode;
                    break;
                }
                Current = Current.Next;
            }
        }

        
    }
}

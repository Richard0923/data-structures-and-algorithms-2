using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }

        public Node<T> Rear { get; set; }

        /// <summary>
        /// Adds a node to the Queue
        /// </summary>
        /// <param name="value"></param>
        public Queue(T value)
        {
            Node<T> node = new Node<T>(value);
            Front = node;
            Rear = node;
        }

        public Queue() { }

        /// <summary>
        /// Adds a node to queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Rear;
            Rear = node;
        }

        /// <summary>
        /// Removes the Front node in the Queue
        /// </summary>
        /// <returns>Returns the value of the node deleted.</returns>
        public T Dequeue()
        {
            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        public T Peek()
        {
            try
            {
                return Front.Value;
            }
            catch (NullReferenceException e)
            {

                throw new NullReferenceException("No node found");
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }
        
        public Stack() { }

        /// <summary>
        /// Creates a new node and adds it to the stack
        /// </summary>
        /// <param name="value"></param>
        public Stack(T value)
        {
            Node<T> node = new Node<T>(value);
            Top = node;
        }

        /// <summary>
        /// Adds a new node to the stack 
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = Top;
            Top = newNode;
        }

        /// <summary>
        /// Removes the Node at the top of the stack
        /// </summary>
        /// <returns>Returns the value of the node that was removed from the stack</returns>
        public T Pop()
        {
            Node<T> temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }

        /// <summary>
        /// Show you the node at the Top of the stack 
        /// </summary>
        /// <returns>Returns the value of the n ode at the top of the stack</returns>
        public T Peek()
        {
            try
            {
                return Top.Value;
            }
            catch (NullReferenceException e)
            {

                throw new NullReferenceException("No node found");
            }
        }

    }
}

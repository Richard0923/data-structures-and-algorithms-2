using System;
using System.Collections.Generic;
using System.Text;


namespace StacksAndQueues.Classes
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        public Stack() { }

        public Stack(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        public void Push(T item)
        {
            
        }
    }
}

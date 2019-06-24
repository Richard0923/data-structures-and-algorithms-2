using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace StackAndQueue.Classes
{
    class Stack
    {
        public Node Top { get; set; }
        

        public Stack() { }

        public Stack(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }
    }
}

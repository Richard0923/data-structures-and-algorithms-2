﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        
        public Node() { }

        public Node(T value)
        {
            Value = value;
        }
    }
}

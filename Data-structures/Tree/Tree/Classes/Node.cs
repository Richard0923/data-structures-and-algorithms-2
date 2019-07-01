using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Node
    {
        //properties for the node class to setup the trees
        public Object Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

         

        public Node(int value)
        {
            Value = value;
        }
    }
}

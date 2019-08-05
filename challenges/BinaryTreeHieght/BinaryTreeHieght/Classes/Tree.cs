using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeHieght.Classes
{
    class Tree
    {
        public Node Root;

        public Tree() { }

        public Tree(Node node)
        {
            Root = node;
        }

        //methods use recursion
        public List<int> PreOrder(Node node)
        {
            List<int> traversal = new List<int>();
            //uses recursion to add nodes to the list so it can be outputed 
            PreOrder(node, traversal);
            return traversal;
        }

        //adds the root fist 
        public void PreOrder(Node node, List<int> traversal)
        {
            //adds the value  of the node to the list so evertime a recursion happens the node comming in will be added 
            traversal.Add((int)node.Value);
            //if the left child is equal to null use recursion to add the element to the list
            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            //does the same but check the right child  
            if (node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }

        }

        public List<int> InOrder(Node node)
        {
            List<int> traversal = new List<int>();
            InOrder(node, traversal);
            return traversal;
        }

        //same as in order but adds the element in a diffrent position with the root in the middle 
        public void InOrder(Node node, List<int> traversal)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }

            traversal.Add((int)node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild, traversal);
            }
        }

        //put the root in the end of the list 
        public List<int> PostOrder(Node node)
        {
            List<int> traversal = new List<int>();
            PostOrder(node, traversal);
            return traversal;
        }

        public void PostOrder(Node node, List<int> traversal)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild, traversal);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild, traversal);
            }

            traversal.Add((int)node.Value);
        }
    }
}

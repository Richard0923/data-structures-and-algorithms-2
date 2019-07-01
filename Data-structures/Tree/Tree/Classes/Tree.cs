using System;
using System.Collections.Generic;
using System.Text;


namespace Tree.Classes
{
    public class Trees
    {

        public Node Root;

        public Trees() { }

        public Trees(Node node)
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

        public void PreOrder(Node node, List<int> traversal)
        {
            //adds the value  of the node to the list so evertime a recursion happens the node comming in will be added 
            traversal.Add((int)node.Value);
            //if the left child is equal to null use recursion to add the element to the list
            if(node.LeftChild != null)
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

        public void InOrder(Node node, List<int> traversal)
        {
            if(node.LeftChild != null)
            {
                
            }
        }

        public void Postorder()
        {

        }

        class BinarySearchTree
        {
            public void Add()
            {

            }

            public void Contains()
            {

            }
        }
    }
}

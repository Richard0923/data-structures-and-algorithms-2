using BinaryTreeHieght.Classes;
using System;

namespace BinaryTreeHieght
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tree testy = new Tree();
            testy.Root = new Node(5);
            testy.Root.LeftChild = new Node(4);
            testy.Root.RightChild = new Node(6);
            testy.Root.LeftChild.LeftChild = new Node(2);
            testy.Root.LeftChild.RightChild = new Node(3);
            testy.Root.RightChild.RightChild = new Node(8);
            testy.Root.RightChild.LeftChild = new Node(7);

            Console.WriteLine(CalculateBinaryTreeHieght(testy.Root));
            Console.WriteLine(IsBalanced(testy.Root));
            Console.WriteLine(IsAncestor(4, 2, testy.Root));
            Console.ReadLine();


        }

        /// <summary>
        /// Calculates the Hieght of a tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns>Returns the hieght of that tree</returns>
        public static int CalculateBinaryTreeHieght(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                int lHieght = CalculateBinaryTreeHieght(root.LeftChild);
                int rHieght = CalculateBinaryTreeHieght(root.RightChild);

                if(lHieght > rHieght)
                {
                    return (lHieght + 1);
                }
                else
                {
                    return (rHieght + 1);
                }
            }
        }

        /// <summary>
        /// Checks if a binary tree is balanced 
        /// </summary>
        /// <param name="node"></param>
        /// <returns>Returns a bool</returns>
        public static bool IsBalanced(Node node)
        {
          
            if(node == null)
            {
                return false;
            }

            int lH = CalculateBinaryTreeHieght(node.LeftChild);
            int rH = CalculateBinaryTreeHieght(node.RightChild);

            if ((lH - rH) <= 1)
            {
                return true;
            }
            return false;
        }

        public static bool IsAncestor(int v1, int v2, Node root)
        {
            Node ancestor = new Node(0);
            if(root == null)
            {
                return false;
            }
            IsAncestor(v1, v2, root.LeftChild);
            IsAncestor(v1, v2, root.RightChild);

            if (root.Value == v1 || root.Value == v2)
            {
                ancestor = root;
               //have an if statment to check of the ancestor value is greater than one 
            }
            



            return false; 
        }
    }
}

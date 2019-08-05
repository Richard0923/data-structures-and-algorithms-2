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
            testy.Root.LeftChild.RightChild = new Node(8);
            testy.Root.LeftChild.LeftChild = new Node(7);

            Console.WriteLine(CalculateBinaryTreeHieght(testy.Root));
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
    }
}

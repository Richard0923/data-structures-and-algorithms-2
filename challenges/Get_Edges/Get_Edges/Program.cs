using Get_Edges.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Get_Edges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public ValueTuple<bool, int> GetEdges(Graph<string> graph, string[] pathArray)
        {
            Queue<Vertex<string>> queue = new Queue<Vertex<string>>();
            HashSet<Vertex<string>> visited = new HashSet<Vertex<string>>();

            Vertex<string> root = graph.GetVertex(pathArray[0]);
            int totalPrice = 0;
            bool flightPossiable = false;

            if(root.Value == null)
            {
                return (flightPossiable, totalPrice);
            }
            queue.Enqueue(root);
            visited.Add(root);

            while(queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                //need to keep working on it 

            }



            
        }
    }
}

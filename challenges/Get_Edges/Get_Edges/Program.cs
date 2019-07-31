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

        public void GetEdges(Graph<string> graph, string[] pathArray)
        {
            List<Vertex<string>> visted = new List<Vertex<string>>();
            Queue<Vertex<string>> breadth = new Queue<Vertex<string>>();

            //vertex to hold the value of the input array
            Vertex<string> arrayValue = new Vertex<string>(pathArray[0]);

            if (graph.AdjacencyList.ContainsKey(arrayValue))
            {
                breadth.Enqueue(arrayValue);
            }
            
            while(breadth.TryPeek(out arrayValue))
            {
                Vertex<string> front = breadth.Dequeue();

                if (visted.Contains(front))
                {
                    continue;
                }
                visted.Add(front);

                foreach (var nieghbors in graph.AdjacencyList[front])
                {
                    if (!visted.Contains(nieghbors))
                    {
                        //need to grab the price and if  there is a path to 
                    }
                }
            }
        }
    }
}

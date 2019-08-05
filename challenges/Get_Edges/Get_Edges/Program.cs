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

            Graph<string> cityGraph = new Graph<string>();

            Vertex<string> pandora = cityGraph.AddVertex("Pandora");
            Vertex<string> Arendelle = cityGraph.AddVertex("Arendelle");
            Vertex<string> Metroville = cityGraph.AddVertex("Metroville");
            Vertex<string> Monstroplolis = cityGraph.AddVertex("Monstroplolis");
            Vertex<string> Narnia = cityGraph.AddVertex("Narnia");
            Vertex<string> Naboo = cityGraph.AddVertex("Naboo");

            cityGraph.AddEdge(pandora, Arendelle, 150);
            cityGraph.AddEdge(pandora, Metroville, 82);
            cityGraph.AddEdge(Arendelle, Metroville, 99);
            cityGraph.AddEdge(Arendelle, Monstroplolis, 42);
            cityGraph.AddEdge(Metroville, Narnia, 37);
            cityGraph.AddEdge(Metroville, Naboo, 26);
            cityGraph.AddEdge(Metroville, Monstroplolis, 105);
            cityGraph.AddEdge(Monstroplolis, Naboo, 73);
            cityGraph.AddEdge(Naboo, Narnia, 250);
            string[] inputarray = new string[2] { "Metroville", "Pandora" };
            var results = GetEdges(cityGraph, inputarray);

            Console.WriteLine($"{results}");
            Console.ReadLine();
        }

        public static ValueTuple<bool, int> GetEdges(Graph<string> graph, string[] pathArray)
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

                if (!visited.Contains(vertex))
                {
                    visited.Add(vertex);
                }
                int i = 1;
                //logic in here is wrong need to brak point it a figure out what is wrong. 
                foreach(var neighbor in graph.AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor.Vertex))
                    {
                        queue.Enqueue(neighbor.Vertex);
                    }
                    if(neighbor.Vertex.Value == pathArray[i])
                    {
                        flightPossiable = true;
                        totalPrice += neighbor.Weight;
                        queue.Enqueue(neighbor.Vertex);
                    }
                }
            }
            return (flightPossiable, totalPrice);




        }
    }
}

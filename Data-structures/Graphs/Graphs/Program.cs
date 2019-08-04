using Graphs.Classes;
using System;

namespace Graphs
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

            cityGraph.AddEdge(pandora, Arendelle, 0);
            cityGraph.AddEdge(Arendelle, Metroville, 0);
            cityGraph.AddEdge(Arendelle, Monstroplolis, 0);
            cityGraph.AddEdge(Metroville, Narnia, 0);
            cityGraph.AddEdge(Metroville, Naboo, 0);
            cityGraph.AddEdge(Metroville, Monstroplolis, 0);
            cityGraph.AddEdge(Monstroplolis, Naboo, 0);
            cityGraph.AddEdge(Naboo, Narnia, 0);

            var bft = cityGraph.BreadthFirst(pandora);

            foreach(Vertex<string> city in bft)
            {
                Console.WriteLine($"{city.Value}");
            }
            Console.ReadLine();

        }
    }
}

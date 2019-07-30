using System;
using System.Collections.Generic;
using System.Text;

namespace Get_Edges.Classes
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        public int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        public void AddEdge(Vertex<T> v1, Vertex<T> v2, int weight)
        {
            AdjacencyList[v1].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = v2
            });
        }

        public void AddUndirectedEdge(Vertex<T> v1, Vertex<T> v2, int weight)
        {
            AddEdge(v1, v2, weight);
            AddEdge(v2, v1, weight);
        }

        public List<Vertex<T>> GetVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var item in AdjacencyList)
            {
                vertices.Add(item.Key);
            }
            return vertices;
        }

        public Dictionary<Vertex<T>, int> GetNeighbors(Vertex<T> findMe)
        {
            Dictionary<Vertex<T>, int> vertices = new Dictionary<Vertex<T>, int>();
            foreach (var item in AdjacencyList[findMe])
            {
                vertices.Add(item.Vertex, item.Weight);
            }

            return vertices;
        }

        public int Size()
        {
            return _size;
        }
    }
}

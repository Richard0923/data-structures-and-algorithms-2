using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        public int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        /// <summary>
        /// Adds a node to the graph 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns the vertex that was just added </returns>
        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        /// <summary>
        /// Adds an Directed edge between two vertices 
        /// </summary>
        /// <param name="v1">Referance of the first node</param>
        /// <param name="v2">Referance of the second node</param>
        /// <param name="weight">The Value of that edge</param>
        public void AddEdge(Vertex<T> v1, Vertex<T> v2, int weight)
        {
            AdjacencyList[v1].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = v2
            });
        }

        /// <summary>
        /// Adds an UnDirected edge between two vertices 
        /// </summary>
        /// <param name="v1">Referance of the first node</param>
        /// <param name="v2">Referance of the second node</param>
        /// <param name="weight">The Value of that edge</param>
        public void AddUndirectedEdge(Vertex<T> v1, Vertex<T> v2, int weight)
        {
            AddEdge(v1, v2, weight);
            AddEdge(v2, v1, weight);
        }

        /// <summary>
        /// Gets all of the Vertices in the graph 
        /// </summary>
        /// <returns>Returns all of the verticies in a List</returns>
        public List<Vertex<T>> GetVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var item in AdjacencyList)
            {
                vertices.Add(item.Key);
            }
            return vertices;
        } 

        /// <summary>
        /// Gets all of the Edges in that graph 
        /// </summary>
        /// <param name="findMe"></param>
        /// <returns>Returns all the edges in a List</returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> findMe)
        {
            return AdjacencyList[findMe];
        }

        /// <summary>
        /// Finds the vertex of the given value 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns that vertex if found</returns>
        public Vertex<T> GetVertex(T value)
        {
            foreach(var vertex in AdjacencyList)
            {
                if (vertex.Key.Value.Equals(value))
                {
                    return vertex.Key;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns the Size of the Graph
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return _size;
        }

        public HashSet<Vertex<T>> BreadthFirst(Vertex<T> start)
        {
            HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            
            //need  to check if node is vaild 
            if(start.Value == null)
            {
                return visited;
            }

            //Enqueue the strating node 
            queue.Enqueue(start);

            //Loop through the graph until the queue is empty 
            while(queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (!visited.Contains(vertex))
                {
                    visited.Add(vertex);
                }

                //finding all of the vertex's neighbors 
                foreach(var neighbor in AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor.Vertex))
                    {
                        queue.Enqueue(neighbor.Vertex);
                    }
                }
            }

            return visited;

        }
    }
}

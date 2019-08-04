using System;
using System.Collections.Generic;
using System.Text;

namespace Get_Edges.Classes
{
   public class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }
    }
}

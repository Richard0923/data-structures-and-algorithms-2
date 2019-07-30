using Graphs.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace GraphsTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddNodetoGraphTest()
        {
            Graph<string> testGraph = new Graph<string>();
            string teststring = "Puerto Rico";

            var result = testGraph.AddVertex(teststring);

            Assert.Contains(teststring, result.Value);
        }

        [Fact]
        public void AddEdgeGraphTest()
        {
            Graph<string> graph = new Graph<string>();
            string teststring1 = "Puerto Rico";
            string teststring2 = "Miami";

            Vertex<string> testvertex1 = graph.AddVertex(teststring1);
            Vertex<string> testvertex2 = graph.AddVertex(teststring2);
            graph.AddEdge(testvertex1, testvertex2, 5);
            int edge = graph.AdjacencyList[testvertex1][0].Weight;

            Assert.Equal(5, edge);
        }

        [Fact]
        public void GetAllVerticesTest()
        {   
            //Arrange
            Graph<int> graph2 = new Graph<int>();
            int testInt1 = 5;
            int testInt2 = 18;
            int testInt3 = 99;
            int testInt4 = 27;

            
            Vertex<int> IntVertex1 = graph2.AddVertex(testInt1);
            Vertex<int> IntVertex2 = graph2.AddVertex(testInt2);
            Vertex<int> IntVertex3 = graph2.AddVertex(testInt3);
            Vertex<int> IntVertex4 = graph2.AddVertex(testInt4);

            List<Vertex<int>> expected = new List<Vertex<int>>();
            expected.Add(IntVertex1);
            expected.Add(IntVertex2);
            expected.Add(IntVertex3);
            expected.Add(IntVertex4);

            //Act
            List<Vertex<int>> results = graph2.GetVertices();

            //Assert
            Assert.Equal(expected, results);
        }

        [Fact]
        public void GetAllNeighborsTest()
        {
            Graph<int> GetNeighborsGraph = new Graph<int>();
            int testInt1 = 5;
            int testInt2 = 18;
            int testInt3 = 99;
            int testInt4 = 27;

            Vertex<int> IntVertex1 = GetNeighborsGraph.AddVertex(testInt1);
            Vertex<int> IntVertex2 = GetNeighborsGraph.AddVertex(testInt2);
            Vertex<int> IntVertex3 = GetNeighborsGraph.AddVertex(testInt3);
            Vertex<int> IntVertex4 = GetNeighborsGraph.AddVertex(testInt4);
            GetNeighborsGraph.AddEdge(IntVertex1, IntVertex2, 3);
            GetNeighborsGraph.AddEdge(IntVertex1, IntVertex3, 7);
            GetNeighborsGraph.AddEdge(IntVertex1, IntVertex4, 8);

            Dictionary<Vertex<int>, int> Nieghbors = GetNeighborsGraph.GetNeighbors(IntVertex1);

            Assert.Equal(GetNeighborsGraph.AdjacencyList[IntVertex1][2].Weight, Nieghbors[IntVertex4]);
        }

        [Fact]
        public void GetGraphSizeTest()
        {
            Graph<int> GetSizeGraph = new Graph<int>();
            int testInt1 = 5;
            int testInt2 = 18;
            int testInt3 = 99;
            int testInt4 = 27;

            Vertex<int> IntVertex1 = GetSizeGraph.AddVertex(testInt1);
            Vertex<int> IntVertex2 = GetSizeGraph.AddVertex(testInt2);
            Vertex<int> IntVertex3 = GetSizeGraph.AddVertex(testInt3);
            Vertex<int> IntVertex4 = GetSizeGraph.AddVertex(testInt4);

            int expectedSize = 4;
            int resultSize = GetSizeGraph.Size();

            Assert.Equal(expectedSize, resultSize);
        }

        [Fact]
        public void EmptyGraphReturnsNullTest()
        {
            Graph<int> emptyGraph = new Graph<int>();

            Assert.Empty(emptyGraph.AdjacencyList);
        }
    }
}

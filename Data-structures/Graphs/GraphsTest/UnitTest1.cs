using Graphs.Classes;
using System;
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
    }
}

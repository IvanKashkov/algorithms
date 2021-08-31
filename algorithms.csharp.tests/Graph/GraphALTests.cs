using algorithms.csharp.Graph.BFS;
using algorithms.csharp.Graph.Structure;
using Xunit;

namespace algorithms.csharp.tests.Graph
{
    
    public class GraphALTests
    {
        [Fact]
        public void BfsTest()
        {
            int n = 6;

            GraphAL<int> graph = new GraphAL<int>(n);

            for (int i = 0; i < n; i++)
            {
                graph.SetVertex(i, i*i);
            }

            graph.SetDuplexOrientedEdge(0, 1);
            graph.SetDuplexOrientedEdge(0, 3);
            graph.SetDuplexOrientedEdge(1, 2);
            graph.SetDuplexOrientedEdge(2, 4);
            graph.SetDuplexOrientedEdge(2, 5);
            graph.SetDuplexOrientedEdge(4, 5);

            var v1 = BfsAl.Find(graph, 0, 25);
            Assert.True(v1.Weight == 25);

            var v2 = BfsAl.Find(graph, 0, 24);
            Assert.False(v1.Weight == 24);
        }
    }
}

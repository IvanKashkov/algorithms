using algorithms.csharp.Graph.BFS;
using algorithms.csharp.Graph.DFS;
using algorithms.csharp.Graph.Structure;
using Xunit;

namespace algorithms.csharp.tests.Graph
{
    public class GraphAMTests
    {
        private GraphAM<int> _graph;

        public GraphAMTests()
        {
            int n = 6;

            _graph = new GraphAM<int>(n);

            for (int i = 0; i < n; i++)
                _graph.SetVertex(i, i * i);

            _graph.SetDuplexOrientedEdge(0, 1);
            _graph.SetDuplexOrientedEdge(0, 3);
            _graph.SetDuplexOrientedEdge(1, 2);
            _graph.SetDuplexOrientedEdge(2, 4);
            _graph.SetDuplexOrientedEdge(2, 5);
            _graph.SetDuplexOrientedEdge(4, 5);
        }

        [Fact]
        public void BfsTest()
        {
            var v1 = BfsAm.Find(_graph, 0, 25);
            Assert.NotEqual(v1.Index, -1);
            Assert.True(v1.Weight == 25);

            var v2 = BfsAm.Find(_graph, 0, 24);
            Assert.Equal(v2.Index, -1);
            Assert.False(v2.Weight == 24);
        }

        [Fact]
        public void DfsStackTest()
        {
            var v1 = DfsAmStack.Find(_graph, 0, 25);
            Assert.NotEqual(v1.Index, -1);
            Assert.True(v1.Weight == 25);

            var v2 = DfsAmStack.Find(_graph, 0, 24);
            Assert.Equal(v2.Index, -1);
            Assert.False(v2.Weight == 24);
        }

        [Fact]
        public void DfsRecursionTest()
        {
            var v1 = DfsAmRecursion.Find(_graph, 0, 25);
            Assert.NotEqual(v1.Index, -1);
            Assert.True(v1.Weight == 25);

            var v2 = DfsAmRecursion.Find(_graph, 0, 24);
            Assert.Equal(v2.Index, -1);
            Assert.False(v2.Weight == 24);
        }
    }
}

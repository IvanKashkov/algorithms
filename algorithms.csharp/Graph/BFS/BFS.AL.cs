using System.Collections.Generic;
using algorithms.csharp.Graph.Structure;

namespace algorithms.csharp.Graph.BFS
{
    public static class BfsAl
    {
        public static Vertex<T> Find<T>(GraphAL<T> graph, int rootIndex, T weight)
            where T : struct
        {
            graph.ClearDiscovered();

            Queue<int> currLevel = new Queue<int>();
            currLevel.Enqueue(rootIndex);

            do
            {
                Queue<int> nextLevel = new Queue<int>();

                var k = currLevel.Dequeue();
                graph.Verteces[k].IsDiscovered = true; // using access by index cause Vertex is struct type

                foreach (var i in graph.AdjacencyList[k])
                {
                    if (Equals(graph.Verteces[i].Weight, weight))
                        return graph.Verteces[i];

                    if (!graph.Verteces[i].IsDiscovered && !nextLevel.Contains(i))
                        nextLevel.Enqueue(i);
                }

                currLevel = nextLevel;
            } while (currLevel.Count > 0);

            return Vertex<T>.Null;
        }
    }
}

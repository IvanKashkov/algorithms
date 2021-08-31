using System.Collections.Generic;
using algorithms.csharp.Graph.Structure;

namespace algorithms.csharp.Graph.DFS
{
    public static class DfsAmStack
    {
        public static Vertex<T> Find<T>(GraphAM<T> graph, int rootIndex, T weight)
            where T : struct
        {
            graph.ClearDiscovered();

            Stack<int> stack = new Stack<int>();
            stack.Push(rootIndex);

            while (stack.Count > 0)
            {
                var k = stack.Pop();
                graph.Verteces[k].IsDiscovered = true;

                for (int i = 0; i < graph.Verteces.Length; i++)
                {
                    if (graph.AdjacencyMatrix[k, i])
                    {
                        if (Equals(graph.Verteces[i].Weight, weight))
                            return graph.Verteces[i];

                        if (!graph.Verteces[i].IsDiscovered)
                            stack.Push(i);
                    }
                }
            }

            return Vertex<T>.Null; 
        }
    }
}

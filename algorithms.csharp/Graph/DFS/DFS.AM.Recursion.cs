using System.Collections.Generic;
using algorithms.csharp.Graph.Structure;

namespace algorithms.csharp.Graph.DFS
{
    public static class DfsAmRecursion
    {
        public static Vertex<T> Find<T>(GraphAM<T> graph, int rootIndex, T weight)
            where T : struct
        {
            graph.ClearDiscovered();

            return FindInternal(graph, rootIndex, weight);
        }

        private static Vertex<T> FindInternal<T>(GraphAM<T> graph, int k, T weight)
            where T : struct
        {
            graph.Verteces[k].IsDiscovered = true;

            for (int i = 0; i < graph.Verteces.Length; i++)
            {
                if (graph.AdjacencyMatrix[k, i])
                {
                    if (Equals(graph.Verteces[i].Weight, weight))
                        return graph.Verteces[i];

                    if (!graph.Verteces[i].IsDiscovered)
                    {
                        var result = FindInternal(graph, i, weight);

                        if (result.Index != -1)
                            return result;
                    }
                }
            }

            return Vertex<T>.Null;
        }
    }
}

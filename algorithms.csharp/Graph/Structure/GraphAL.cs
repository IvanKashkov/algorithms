using System.Collections.Generic;

namespace algorithms.csharp.Graph.Structure
{
    /// <summary>
    /// Graph as Adjacency List
    /// </summary>
    public class GraphAL<T>
        where T : struct
    {
        public GraphAL(int n)
        {
            Verteces = new Vertex<T>[n];
            AdjacencyList = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                AdjacencyList[i] = new List<int>();
            }

        }

        public Vertex<T>[] Verteces { get; private set; }

        public List<int>[] AdjacencyList { get; private set; }

        /// <param name="k">index</param>
        /// <param name="val">value</param>
        public void SetVertex(int k, T val)
        {
            Verteces[k] = new Vertex<T>(k, val);
        }

        public void SetOrientedEdge(int i, int j)
        {
            AdjacencyList[i].Add(j);
        }

        public void SetDuplexOrientedEdge(int i, int j)
        {
            AdjacencyList[i].Add(j);
            AdjacencyList[j].Add(i);
        }

        public void ClearDiscovered()
        {
            for (int i = 0; i < Verteces.Length; i++)
                Verteces[i].IsDiscovered = false;
        }

    }
}

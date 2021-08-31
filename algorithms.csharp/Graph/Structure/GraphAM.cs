namespace algorithms.csharp.Graph.Structure
{
    /// <summary>
    /// Graph as Adjacency Matrix
    /// </summary>
    public class GraphAM<T> where T : struct
    {
        public GraphAM(int n)
        {
            Verteces = new Vertex<T>[n];
            AdjacencyMatrix = new bool[n, n];
        }

        public Vertex<T>[] Verteces { get; private set; }

        public bool[,] AdjacencyMatrix { get; private set; }

        /// <param name="k">index</param>
        /// <param name="val">value</param>
        public void SetVertex(int k, T val)
        {
            Verteces[k] = new Vertex<T>(k, val);
        }

        public void SetOrientedEdge(int i, int j)
        {
            AdjacencyMatrix[i, j] = true;
        }

        public void SetDuplexOrientedEdge(int i, int j)
        {
            AdjacencyMatrix[i, j] = true;
            AdjacencyMatrix[j, i] = true;
        }

        public void ClearDiscovered()
        {
            for (int i = 0; i < Verteces.Length; i++)
                Verteces[i].IsDiscovered = false;
        }
    }
}

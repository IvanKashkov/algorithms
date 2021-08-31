namespace algorithms.csharp.Graph.Structure
{
    public struct Vertex<T> 
        where T : struct
    {
        public Vertex(int index, T weight)
        {
            Index = index;
            Weight = weight;
            IsDiscovered = false;
        }

        public int Index { get; private set; }
        public T Weight { get; private set; }
        public bool IsDiscovered { get; set; }

        public static Vertex<T> Null = new Vertex<T>(-1, default(T));
    }
}
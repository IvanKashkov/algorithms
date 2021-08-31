using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithms.csharp.Tasks
{
    public class HanoiState
    {
        public static HanoiState Init(int n = 3)
        {
            var state = new HanoiState
            {
                From = new Stack<int>(), 
                To = new Stack<int>(), 
                Buf = new Stack<int>()
            };

            for (int i = n; i > 0; i--)
                state.From.Push(i);

            state.Size = n;

            state.Logs = new StringBuilder();

            return state;
        }

        public Stack<int> From { get; private set; }
        public Stack<int> To { get; private set; }
        public Stack<int> Buf { get; private set; }

        public int Size { get; private set; }


        public StringBuilder Logs { get; private set; }

        public void LogState()
        {
            Logs.AppendLine($"from: {String.Join(",", this.From.Reverse().Select(x => x.ToString()))}, to: {String.Join(",", this.To.Reverse().Select(x => x.ToString()))}, buf: to: {String.Join(",", this.Buf.Reverse().Select(x => x.ToString()))}");
        }

    }

    public static class HanoiTower
    {
        /// <summary>
        /// Solve Hanoi Tower algorithm
        /// </summary>
        /// <param name="size">Size of initial "From" Stack</param>
        /// <param name="n">Number of Items to move</param>
        /// <param name="f">Stack "From"</param>
        /// <param name="t">Stack "To"</param>
        /// <param name="b">Stack "Buffer"</param>
        /// <param name="state">We pass state Just for logging recursion</param>
        public static void Solve(int size, int n, Stack<int> f, Stack<int> t, Stack<int> b, HanoiState state)
        {
            if (n <= 0)
                return;
            
            HanoiTower.Solve(size, n - 1, f, b, t, state);

            state.LogState();

            var val = f.Pop();
            t.Push(val);

            state.LogState();

            HanoiTower.Solve(size, n - 1, b, t, f, state);
        }
    }
}

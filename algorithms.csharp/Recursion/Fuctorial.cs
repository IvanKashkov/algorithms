using System;

namespace algorithms.csharp.Recursion
{
    public static class Fuctorial
    {
        public static int CalcRec(int n)
        {
            if (n == 1)
                return 1;

            return n * CalcRec(n - 1); 
        }

        public static int CalcTailRec1(int n, int acc = 1)
        {
            return CalcTailRec1(n - 1, acc * n);
        }

        public static int CalcTailRec2(int n)
        {
            Func<int, int, int> f = null;
                
            f = (m, acc) =>
            {
                if (m == 1)
                    return acc;

                return f(m - 1, acc * m);
            };

            return f(n, 1);
        }

        public static int CalcCycle(int n)
        {
            int result = 1;

            while (n > 1)
            {
                result *= n;
                n--;
            }

            return result;
        }
    }
}

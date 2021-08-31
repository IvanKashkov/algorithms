namespace algorithms.csharp.Sortings
{
    public static class SelectSort
    {
        public static int[] Sort(int[] arr)
        {
            // 1. Select minimum value
            // 2. Place minimum value on it's position

            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                var current = arr[i];
                var index = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < current)
                    {
                        current = arr[j];
                        index = j;
                    }
                }

                if (index != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                }
            }

            return arr;
        }

       
    }
}

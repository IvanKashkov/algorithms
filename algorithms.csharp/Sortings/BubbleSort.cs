namespace algorithms.csharp.Sortings
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            // 1 iteration moving the max value to the end
            // 2 iteration moving the second max value to before the end 
            // and so on
            // ....

            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    int first = arr[j];
                    int second = arr[j + 1];

                    if (first > second)
                    {
                        arr[j] = second;
                        arr[j + 1] = first;
                    }
                }
            }

            return arr;
        }
    }
}

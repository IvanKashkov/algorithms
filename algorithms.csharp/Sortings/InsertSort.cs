namespace algorithms.csharp.Sortings
{
    public static class InsertSort
    {
        public static int[] Sort(int[] arr)
        {
            // from i = 1 to n 
            // try to find position with shifting all prev element to right

            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;
                while (arr[j] > current && j >= 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
            }

            return arr;
        }
    }
}

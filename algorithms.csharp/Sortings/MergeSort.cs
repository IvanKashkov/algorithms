namespace algorithms.csharp.Sortings
{
    public static class MergeSort
    {
        /*
        1. Recursive function of sort
        2. Split array on 2 array
        3. Sort each separately
        4. Merge them into one
        */

        public static int[] Sort(int[] arr)
        {
            int length = arr.Length;

            if (length == 1)
                return arr;

            if (length == 2)
            {
                if (arr[0] > arr[1])
                {
                    int dummy = arr[0];
                    arr[1] = arr[0];
                    arr[0] = dummy;
                }

                return arr;
            }

            int middle = length / 2;

            int[] arrLeft = new int[middle];
            int[] arrRight = new int[length - middle];

            for (int i = 0; i < arrLeft.Length; i++)
                arrLeft[i] = arr[i];
            
            for (int j = 0; j < arrRight.Length; j++)
                arrRight[j] = arr[j + middle];

            arrLeft = Sort(arrLeft);
            arrRight = Sort(arrRight);

            int[] result = Merge(arrLeft, arrRight);

            return result;
        }

        private static int[] Merge(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            int i = 0;
            int j = 0;
            int k = 0;
            
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                    result[k] = arr1[i++]; 
                else
                    result[k] = arr2[j++];

                k++;
            }

            for (int l = i; l < arr1.Length; l++)
                result[k++] = arr1[i];

            for (int l = j; l < arr2.Length; l++)
                result[k++] = arr2[j];

            return result;
        }
    }
}


using System;
namespace Q_sort
{
    class Sorting
    {
        public static void Main()
        {
            int[] arr = { 8, 2, 4, 5, 1, 7, 2, 6, 3 };
            Solve val = new Solve();
            val.action(arr,0,arr.Length-1);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class Solve
    {
        public int[] action(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                action(array, leftIndex, j);
            if (i < rightIndex)
                action(array, i, rightIndex);
            return array;
        }

    }
}

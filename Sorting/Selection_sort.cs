using B_sort;
using System;
namespace B_sort
{
    class Sorting
    {
        public static void Main()
        {
            int[] arr = { 8, 2, 4, 5, 1, 7, 9, 6, 3 };
            Solve val = new Solve();
            val.action(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
    class Solve
    {
        public int[] action(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
            return (arr);
        }

    }

/* Worst Case Time Complexity is: O(N2)
Average Case Time Complexity is: O(N2)
Best Case Time Complexity is: O(N2)
Space Complexity: O(1)
 */

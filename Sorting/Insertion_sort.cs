using B_sort;
using System;
using System.Globalization;

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
        int temp, j;   
            for (int i = 1; i < arr.Length; i++)
            {
                 temp = arr[i];
                 j = i - 1;
                 while(j>=0 && arr[j] > temp)
                 {
                      arr[j+1] = arr[j];
                      j--;
                 }
              arr[j + 1] = temp;
            }
            return (arr);
        }

    }
    
   Time Complexity: O(N^2) 
   Auxiliary Space: O(1) 

using System;
namespace Counting
{
    class Count_sort
    {
        public static void Main(String[] args)
        {
            int[] arr = { 1, 4, 1, 2, 7, 5, 2 };
            int[] index = new int[10];
            int[] Output = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                index[arr[i]] += 1;
            }

            for (int j = 0; j < index.Length - 1; j++)
            {
                index[j + 1] += index[j];
            }

            for (int k = 0; k < arr.Length; k++)
            {
                Output[index[arr[k]]] = arr[k];
                // Console.Write(Output[index[arr[k]]]);
                index[arr[k]] -= 1;

            }
            for (int i = 1; i < Output.Length; i++)
            {
                Console.Write(Output[i]);
            }
        }
    }
}

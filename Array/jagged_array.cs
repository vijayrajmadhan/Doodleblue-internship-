using System;
using System.Linq;//namespace

class array
{
    public static void Main(string[] args)
    {
       //jagged array
       int[][] arr=new int[2][];
       
        arr[0]=new int[5]{5,6,7,8,9};
        arr[1]=new int[4]{2,3,4,5};
       
       for(int i=0;i<arr.Length;i++)
       {
           Console.Write("elements of "+i+" :");
           for(int j=0;j<arr[i].Length;j++)
           {
               Console.Write(arr[i][j]);
           }
           Console.WriteLine("");
       }
       
       
    }
}

/* A jagged array is an array whose elements are arrays, possibly of different sizes.
A jagged array is sometimes called an "array of arrays." 
the array elements will have different size elements to make it posible the jagged array is used.
*/

using System;
using System.Linq;//namespace

class array
{
    public static void Main(string[] args)
    {
       //nested loop
       int[] arr={2,3,4,5,6,7,8};
       for(int i=0;i<arr.Length;i++)//outer loop
       {
           for(int j=i+1;j<arr.Length;j++)//inner loop
           {
               if(arr[i]<arr[j])
               {
                   int temp=arr[i];
                   arr[i]=arr[j];
                   arr[j]=temp;
               }
           }
       }
       Console.Write("the decending order values :");
       
       for(int k=0;k<arr.Length;k++)
       {
           Console.Write(arr[k]);
       }
      
    }
}

/* mostly nested loop is used for sorting the array and table using the array like multi-dimentional array
if the outer loop execute 5 times than the inner loop will execute for 25 times
it is the mostly nested loops are used*/

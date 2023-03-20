using System;
using System.Linq;//namespace

class array
{
    public static void Main(string[] args)
    {
       //for each loop
       int[] arr={2,3,4,5,6,7,8};
       foreach(int i in arr)
       {
           Console.WriteLine(i);
       }
      
    }
}

/* The foreach loop, which is used to loop through elements in an array:
the foreach loop was bben intigating that it will run to every element in the array

If you compare the for loop and foreach loop, you will see that the foreach method is easier to write,
it does not require a condition, and it is more readable.

but it cannot ru the array value half it will run full array values*/

using System;

class array
{
    public static void Main(string[] args)
    {
        int[] arr={6,5,3,4,2,1}; //the array is decleared directly without any keyword just giving the elements directly
        Array.Sort(arr);
        String[] arr1={"hello","how","r","you"}; //the array is decleared directly without any keyword just giving the elements directly
        Array.Sort(arr1);
         for(int i=0;i<arr.Length;i++)
        {
          //  arr[i]=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("the value "+i+"is:"+arr[i]);
        }
         for(int i=0;i<arr1.Length;i++)
        {
          //  arr[i]=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("the value "+i+"is:"+arr1[i]);
        }
    }
}

/* hear we are sorting the values according to the assending order using the Sort function it is an in built function.
that is what we used hear */

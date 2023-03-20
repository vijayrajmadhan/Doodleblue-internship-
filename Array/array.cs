using System;

class array
{
    public static void Main(string[] args)
    {
        int[] arr=new int[10];  // the array is decleared with new key word and giving the size of the array
        for(int i=0;i<10;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
         for(int i=0;i<10;i++)
        {
          //  arr[i]=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("the value "+i+"is:"+arr[i]);
        }
    }
}


/* in the given program the array is decleard with the new keyword and in the square bracket the array size was also decleard. 
if we decleared the array size than the values can be used only within that size.the array size was decleard but the array elements was set to array lateley.

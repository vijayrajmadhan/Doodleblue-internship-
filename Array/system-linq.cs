using System;
using System.Linq;//namespace

class array
{
    public static void Main(string[] args)
    {
        int[] arr={6,5,3,4,2,1}; //the array is decleared directly without any keyword just giving the elements directly
        //  arr[i]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the hidhest value :"+ arr.Max());
        Console.WriteLine("the smallest value :"+ arr.Min());
        Console.WriteLine("the sum of all value :"+ arr.Sum());
    }
}

/* here we can see the somr other inbuilt namespace functions like,
Max(),Min(),Sum() this are some inbuilt functions that is used to sinf the arrays minimam ,maximum,addition.

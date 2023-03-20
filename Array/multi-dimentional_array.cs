using System;
using System.Linq;//namespace

class array
{
    public static void Main(string[] args)
    {
        int[,] arr={{1,2,3},{4,5,6}}; // it is declaration of two dimensional array that as the rows and columuns 
        int[,,] arr1={{{1,2,3,4,5}},{{4,5,6,5,6}},{{7,8,9,4,5}}};// it is three dimentional array that need to have two curlybracess for each dimention
        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                Console.Write(arr[i,j]);
            }
            Console.WriteLine("");
        }
        
        Console.WriteLine("********************************************************************************");
        
        for(int i=0;i<arr1.GetLength(0);i++)
        {
            for(int j=0;j<arr1.GetLength(1);j++)
            {
                for(int k=0;k<arr1.GetLength(2);k++)
                {
                   Console.Write(arr1[i,j,k]);
                }
            }
            Console.WriteLine("");
        }
    }
}

/* in multi-dimentional array the [GetLength()] it will be very useful 
=>The .GetLength(0) method returns number of elements in the row direction in a multidimensional array.
For a 2x6 array that is 2.

=>The .GetLength(1) method returns number of elements in the column direction in a multidimensional array.
For a 2x6 array that is 6.  

the multidimentional array has the rows and columuns the can two dimentional array,three dimentional array and etc

int[,] arr2d; // two-dimensional array
int[, ,] arr3d; // three-dimensional array
int[, , ,] arr4d ; // four-dimensional array
int[, , , ,] arr5d; // five-dimensional array  

if u need to store the data in table like it as Rows and Columns that time the multidimentional array is use full*/

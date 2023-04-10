// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 32, 3, 4, 44, 65, 81, 23, 65, 34, 54, 65 };
            var brr=from i in arr select i;
            var brr1 = from i in arr where i > 40 select i;
            var brr2 = from i in arr where i > 40 orderby i descending select i;
            foreach(int x  in brr2) 
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            foreach (int x in brr1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();    
            foreach (int x in brr )
            {
                Console.Write(x + " ");
            }

        }
    }
}

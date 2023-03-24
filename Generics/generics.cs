

using System;
namespace Generices
{

    class Compare<T>
    {
        public bool Myclass(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class Generic_method
    {
        public static void Main(String[] args)
        {
            Compare<int> lst = new Compare<int>();
            bool res = lst.Myclass(2,2);
            Console.WriteLine(res);

            Compare<string> lst1 = new Compare<string>();
            bool res1 = lst1.Myclass("a","b");
            Console.WriteLine(res1);

        }
    }

  
}


/* it is the code reuseability,
 * here we decleread only once the my class and it will compare the values at any data type
 * it is known as generics */
 
 /* =>it is advanced model of the collections
=>it will be type safety
=>Code reuse and less code
=>Increased Performance  
=>the <Thing>or<T> the will store all the data types   */

using System;
using System.Linq;//namespace

class array
{
    public static void Main(string[] args)
    {
        //while loop
        int i=0;
        while(i!=5)
        {
            Console.WriteLine("the out put is :"+i);
            i++;
        }
        Console.WriteLine("*******************************************************************************");
        
        //do...while loop
        int j=0;
        do
        {
            Console.WriteLine("the out put of the Do while loop :"+j);
        }
        while(j!=0);
    }
}

/* while is the type of loop that will excute the code till it condition if false
do...while loop will be execute the code once without checking the condition in while.
while loop will check each and every condition from first 
tis is the basic diffrent between the do...while loop and while loop.  */

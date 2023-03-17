using System;
namespace console_application
{
   class calculator
   {
    static void Main(String[] args)
    {
      arithmetic cal=new arithmetic();
      cal.calculator_1();
    }
   }
}

class arithmetic
{
    public void calculator_1()
    {
    Console.Write("Enter how many number :");
    int total_number=Convert.ToInt32(Console.ReadLine());
    
    
    Console.WriteLine("Enter the operation");
    if(total_number>2)
    {
        Console.WriteLine("1.ADD");
        Console.WriteLine("2.SUBRACTION");
        Console.WriteLine("3.MULTIPLICATION");
    }
    else if(total_number==2)
    {
        Console.WriteLine("4.DIVISION");    
    }
    
    Console.Write("Enter the operation u need to do :");
    int operation=Convert.ToInt32(Console.ReadLine());
    if(operation > 4 || operation < 1)
    {
        Console.Write("Enter the correct value");
    }
    else
    {
        switch(operation)
        {
        case 1:
        {
            int[] values=new int[total_number];
            for(int i=0;i<total_number;i++)
            {
                Console.Write("Enter the "+i+" number :");
                values[i]=Convert.ToInt32(Console.ReadLine());
            }
            int add_out=0;
            for(int i=0;i<total_number;i++)
            {
                add_out+=values[i];
            }
            Console.Write("the output of the addition numbers ="+add_out);
            break;
        }
        case 2:
        {
            int[] values=new int[total_number];
            for(int i=0;i<total_number;i++)
            {
                Console.Write("Enter the "+i+" number :");
                values[i]=Convert.ToInt32(Console.ReadLine());
            }
            // //changing into assending order
            // for(int i=0;i<total_number;i++)
            // {
            //     for(int j=i+1;j<total_number;i++)
            //     {
            //         if(values[i]<values[j])
            //         {
            //             int temp=values[i];
            //             values[i]=values[j];
            //             values[j]=temp;
            //         }
            //     }
            // }
            
            int sub_out=values[0];
            for(int i=1;i<total_number;i++)
            {
                sub_out-=values[i];
            }
            Console.Write("the output of the subraction numbers ="+sub_out);
            break;
        }
        }
    }
    }

}





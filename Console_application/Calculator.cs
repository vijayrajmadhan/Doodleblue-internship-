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


//*******************************************************************************************************************

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
    else if(total_number==1)
    {
        Console.WriteLine("5.SQUARE");
    }
    
    Console.Write("Enter the operation u need to do :");
    int operation=Convert.ToInt32(Console.ReadLine());
    if(operation > 5 || operation < 1)
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
            Console.WriteLine("1.Positive");
            Console.WriteLine("2.Negative");
            Console.WriteLine("3.As it is");
            Console.Write("if output need to be in positive or negative or as it is :");
            int sub_out_inte=Convert.ToInt32(Console.ReadLine());
            switch(sub_out_inte)
            {
                case 1:
                {
                    //changing into assending order
                    for(int i=0;i<total_number;i++)
                    {
                        for(int j=i+1;j<total_number;j++)
                        {
                            if(values[i]<values[j])
                            {
                                int temp=values[i];
                                values[i]=values[j];
                                values[j]=temp;
                            }
                        }
                    }
                    break;
                }
                case 2:
                {
                    for(int i=0;i<total_number;i++)
                    {
                        for(int j=i+1;j<total_number;j++)
                        {
                            if(values[i]>values[j])
                            {
                                int temp=values[i];
                                values[i]=values[j];
                                values[j]=temp;
                            }
                        }
                    }
                    break;
                }
                case 3:
                {
                    break;
                }
            }
            int sub_out=values[0];
            for(int i=1;i<total_number;i++)
            {
                sub_out-=values[i];
            }
            Console.Write("the output of the subraction numbers ="+sub_out);
            break;
        }
        case 3:
        {
            int[] values=new int[total_number];
            for(int i=0;i<total_number;i++)
            {
                Console.Write("Enter the "+i+" number :");
                values[i]=Convert.ToInt32(Console.ReadLine());
            }
            int mul_out=1;
            for(int i=0;i<total_number;i++)
            {
                mul_out*=values[i];
            }
            Console.Write("the output of the Multiplicaton numbers ="+mul_out);
            break;
        }
        case 4:
        {
            int[] values=new int[total_number];
            for(int i=0;i<total_number;i++)
            {
                Console.Write("Enter the "+i+"number :");
                values[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("1.Quotient");
            Console.WriteLine("2.Remainder");
            Console.Write("Enter what output you need to find :");
            int div_out_find=Convert.ToInt32(Console.ReadLine());
            int div_out=0;
            switch(div_out_find)
            {
                case 1:
                {
                    div_out=values[0]/values[1];
                    Console.Write("the output of the Division numbers ="+div_out);
                    break;
                }
                case 2:
                {
                    div_out=values[0]%values[1];
                    Console.Write("the output of the Division numbers ="+div_out);
                    break;
                }
            }
            break;
        }
        case 5:
        {
            Console.Write("Enter the value you need to Square :");
            int squ_val=Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter how many times need to square the value :");
            int number_of_sq=Convert.ToInt32(Console.ReadLine());
            
            double squ_out=Math.Pow(squ_val,number_of_sq);
            Console.Write("the output of the Square numbers ="+squ_out);
            break;
        }
        }
    }
    }

}




//it is the console application that i was been implimented till now
//you can add,sub,mul,div,squ the values hear


using System;
class solve
{
    public int add(int val1,int val2)
    {
        return(val1+val2);
    }
    public double add(double val1,double val2)
    {
        return(val1+val2);
    }
    
}

class compile_time 
{
      static void Main() 
       {
            solve obj=new solve ();
            int out1=obj.add(10,20);
            double out2=obj.add(2.5,3.5);
            Console.WriteLine("the int value output:"+ out1);
            Console.WriteLine("the double value output:"+ out2);
       }
}


/* in polymorphism there are tow types 

=>compile time polymorphism
=>run time polymorphism

the above program if for compile time polymorphism
in this mathod the name and class will be same but,
the argument will be diffrent it will find it by 
run time so it is called compile time polymorphism

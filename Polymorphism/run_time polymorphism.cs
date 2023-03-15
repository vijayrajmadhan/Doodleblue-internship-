
using System;
class solve
{
  public virtual int Area()
  {
      return 0;
  }
    
}

class valone:solve
{
    int a;
    public valone(int a1)
    {
        a=a1;
    }
    public override int Area()
    {
        Console.WriteLine("the value one is called");
        return a*a;
    }
}

class valtwo:solve
{
    int b,c;
    public valtwo(int cal1,int cal2)
    {
        b=cal1;
        c=cal2;
    }
    public override int Area()
    {
        Console.WriteLine("the value two is called");
        return b*c;
    }
}

class run_time 
{
      static void Main() 
       {
           solve obj1=new valone(30);
           int first=obj1.Area();
           Console.WriteLine("out1:"+first);
           
           
           solve obj2=new valtwo(10,20);
           int second=obj2.Area();
           Console.WriteLine("out2:"+second);
       }
}


/* in run time polymorphism we will be using the virtual keyword for achive the overriding concept 
in runtime polymorphism the name of function and argument will be same,but siffrent class and with inheritance relationship
it is the condition of run time polymorphism


using System;
interface solve
{
    void Area();
}

interface solve2
{
    void Area2();
}

class valone:solve,solve2
{
    public void Area()
    {
        Console.WriteLine("the interface class is implimented");
    }
    
    public void Area2()
    {
        Console.WriteLine("multiple interface is implimented");
    }
}

class main
{
    static void Main(String[] args)
    {
        valone obj=new valone();
        obj.Area();
        obj.Area2();
      
    }
}

/* the multiple interface is to achive the abstraction multiple times
it is same as interface,we can impliment it many times



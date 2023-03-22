
using System;
interface solve
{
   void Area();
}

class valone:solve
{
    public void Area()
    {
        Console.WriteLine("the interface class is implimented");
    }
}

class Main
{
    static void Main(String[] args)
    {
        valone obj=new valone();
        obj.Area();
      
    }
}

/* anotherway to achive abstraction is interface
the member of interface is, abstract and public
to use the interface it need to be inherited by the  other class
no need to use override keyword when you implement interface 
in abstract you need to use override key word */

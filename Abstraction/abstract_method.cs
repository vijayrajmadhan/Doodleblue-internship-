
using System;
abstract class solve
{
  public abstract void Area();
}

class valone:solve
{
    public override void Area()
    {
        Console.WriteLine("the value one is called");
    }
}

class main
{
    static void Main(String[] args)
    {
        valone obj=new valone();
        obj.Area();
    }
}

/* in abstract class is used to hide the unnecessory data to the user.
in abstract class only one method should need to be abstract.
the abstract class is an incomplete class it need to be completed in the next class it is inherited
the method declerd in abstract, class should also need to be abstract
abstract class can't create the object */


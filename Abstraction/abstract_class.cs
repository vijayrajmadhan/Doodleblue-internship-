using System;
abstract class solve
{
  public void Area()
  {
      Console.WriteLine("abstract class");
  }
}

class valone:solve
{
   
}

class Abstract
{
    static void Main(String[] args)
    {
        valone obj=new valone();
        obj.Area();
    }
}

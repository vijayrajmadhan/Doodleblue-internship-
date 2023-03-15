

using System;

namespace border
{
  class Program
  {
    static void Main(string[] args)
    {
    try{
     int[] a={10,20,30};
     Console.WriteLine(a[10]);     
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    try{
     int[] a={10,20,30,40};
     Console.WriteLine(a[5]);     
    }
    catch(Exception e)
    {
        Console.WriteLine("the given index value is in correct ");
    }
    finally
    {
        Console.WriteLine("the try....catch is executed");
    }
    }
  }
}


/* try and catch is used to check the condition or statement given is correct or not and give the 
acknowledment.try will execute it and catch will give the acknowledment 
 there is another keywoed finally it will used to execute the  task ahter completing try...and...catch*/

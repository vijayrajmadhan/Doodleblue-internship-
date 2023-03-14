

using System;
namespace SINGLE_INHERITANCE
{
class parent
{
  public int a;
  public void val()
  {
      a=44;
  }
}

class child:parent
{
    public int b;
    public void val2()
    {
        b=10;
    }
    public int output()
    {
        return a*b;
    }
}

class main
{
  static void Main(string[] args)
  {
    child myObj = new child();
    myObj.val();
    myObj.val2();
   // myObj.output();
    Console.WriteLine("output value :"+ myObj.output());
  }
}
}



/* single inhertance will always have one base calss(parent class) and one derived class(child class)
using inheritance we can reduce the code complexity 
for example:mobile(base class)   java mobile(derived class) */
              |                     |
     */    [call,sms]             [games]
               |_____________________|
                          |
                     [sms,games,call]              */
                     
 //  we  access the base class using the derived class */

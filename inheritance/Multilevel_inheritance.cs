

using System;
namespace MULTILEVEL_INHERITANCE
{
class multi_level
{
    public static int saving=30000,amt; 
class parent
{
    public int balance;
  public void total_amount() //member function
  {
      Console.WriteLine("saving :"+saving);//balance in bank account
  }
}
class intermediate:parent
{
    public void debited(int samount)
    {
         amt=samount;
         balance=saving-amt;
        Console.WriteLine("The balance after gpaying the amount :"+ balance);
    }
}


class child:intermediate
{
    public void credited(int cre_amount)
    {
        amt=cre_amount;
        saving=balance+amt;
        Console.WriteLine("the total balamce :"+saving);
    }
}

class main
{
  static void Main(string[] args)
  {
    child myObj = new child();
    myObj.total_amount();
    myObj.debited(5000);
    myObj.credited(10000);
    //Console.WriteLine("output value :"+ myObj.output());
  }
}
}
}


/* in multilevel inheritance there will class will act a both base class and drived class 
for example in program,
there was the class intermediate it will be acting as base class for child(derived) class and 
it will act as derived class for parant class(base class)  */ 

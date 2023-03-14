using System;
class property
{
  private string name;

  public string Name   
  {
    get { 
        return name;
        }  
    set { 
        name = value;
        }  
  }
}
class encasulation
{
  static void Main(string[] args)
  {
    property myObj = new property();
    myObj.Name = "ddd";
    //myObj.Name = "dhf";
    Console.WriteLine(myObj.Name);
  }
}

/*  the encasulation is used to hide data form the user 
to achive Encasulation need to declare the variable in pivate and 
provide public [get and set] method to access the data in private in same class. get and set is an Properties
using get we can make the data in private as read only , using set method we can make the data Write only
using both it can be read and write option to user.
programmer can change the part code without affecting the other part of code
Eg: Encapsulation  - a driver you know how to start the car by pressing the start button and internal details 
of the starting operations are hidden from you. So the entire starting process is hidden from you 
otherwise we can tell starting operation is encapsulated from you.
*/

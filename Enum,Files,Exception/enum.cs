using System;
class val{
  enum solve
  {
    low,
    mediam,
    high
  }


    static void Main(String[] args)
    {
       solve obj=solve.mediam;
       Console.WriteLine(obj);
      
    }
}

/*enum is a special class that represents a group of constants.unchangeable,read-only variables.
use the enum keyword instead of class and interface
if it is in same class than it can be also created object*/

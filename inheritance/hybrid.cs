

using System;
using System.IO; 

namespace MyApplication
{
   
   class app1
    {
         public int val1;
        public void cal1()
        {
            val1=10;
            //Console.WriteLine("the val1 :"+val1);
        }
        
    }
    class app2:app1
    {
        public int val2;
        public int cal2(int n)
        {
            val2=n*val1;
            return(n*val1);
        }
    }
    class app3:app1
    {
        public int val3;
        public int cal3(int m)
        {
            val3=m*val1;
            return(val3);
        }
    }
    class hybrid:app3
    {
        public int val4;
        public void cal4()
        {
            val4=val1*5;
            Console.WriteLine("the hybrid value output :"+val4);
        }
    }

  class Program
  {
    static void Main(string[] args)
    {
        
      app2 myobj1=new app2();
      app3 myobj2=new app3();
      hybrid myobj3=new hybrid();
      myobj1.cal1();
      myobj2.cal1();
      Console.WriteLine("the output of app2: "+myobj1.cal2(10));
      Console.WriteLine("the output of app3: "+myobj2.cal3(20));
      myobj3.cal1();
      myobj3.cal4();
    }
  }
}

/* hybrid inhertance is defined as the inheritance which is a combination of more than one type of inheritance
the usual case in multiple inheritance is when two class are derived from one parent */

using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpShell;

class Public
{         
        public String model="Data";
				
}

class program
{
      static void Main(string[] args)
		{
			 obj=new Public();
			Console.WriteLine(obj.model);
		}
}
/* in public access modifier you can 
used the data on the other class also */

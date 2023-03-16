using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpShell

{

public class Private
{         
        private String model="Data";
		
		static void Main(string[] args)
		{
			 Private obj=new Private();
			Console.WriteLine(obj.model);
		}
}

}

/* if you try to access model data in 
other class it will give the error 
like "access_modify.model is inaaccessible" 
the code is only accessible within the same class */

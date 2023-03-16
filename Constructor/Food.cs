using System;

using System.Linq;

using System.Collections.Generic;



namespace Constructor

{

public class Food 

{         

       public String model;
       public String type;
	   

	  public Food(String modelName)//can add as many parameter you want

	  {
      type=modelName;
	    model="banana";

	  }

	  

	  static void Main(String[] args)

	  {

	     Food myobj=new Food("fruit");//it will set intial values to model

		 Console.WriteLine(myobj.model);
     Console.WriteLine(myobj.type);

	  }

}
}

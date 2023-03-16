using System;
public class Father
{
	public string FatherName()
	{
		return "Ravi";
	}
}


public class ChildFirst : Father
{
	public string ChildDName()
	{
		return "Rohan";
	}
}


public class ChildSecond : Father
{
	public string ChildDName()
	{
		return "Nikhil";
	}
}

namespace fa{
class main{

static public void Main()
{
	ChildFirst first = new ChildFirst();
	

	System.Console.WriteLine("My name is " + first.ChildDName() +
					". My father name is " +
					first.FatherName() + ".");
	ChildSecond second = new ChildSecond();
	

	System.Console.WriteLine("My name is " + second.ChildDName() +
					". My father name is " +
					second.FatherName() + ".");
}
}
}


/* in hierarchical inheritance for one base class there will be more than one derived class 
for example:
               two cat's as the same weight but diffrenet height and wigth.so,weight will be 
               derived in the base class and after that two child class will be creatd for cat 1 and cat2 
               using diffrent values in each derived class get the value from the base class and we can fine the length of the cat


using System;

class HelloWorld 
{
  static void Main() 
  {
      int[] arr={2,3,4,5,6,7,8};
      try
      {
          Console.WriteLine("the exception::"+arr[10]);
      }
      catch(Exception)
      {
          Console.WriteLine("it is been exception type");
      }
      finally
      {
          Console.WriteLine("the try is been as wrong data so the catch is executed");
      }
      Console.WriteLine("*******************************************************************************");
      
  }
}

/* it will give the error message to the user when the try statement as the error

1. StackOverflowException - This exception is thrown when the execution stack exceeds the stack size. 
Normally occurs when we use an infinite loop in the program.

2. ArithmeticException - This exception is thrown for errors in arithmetic, casting, or conversion. 
It is a base class for exception classes like:
              =>DivideByZeroException - This exception is thrown when an integer is divided by 0. 
                For example, when we try to perform 5 divided by 0.

              =>NotFiniteNumberException - This exception is thrown when a floating-point value is positive 
                or negative infinity or NaN (Not-a-Number).
                
              =>OverFlowException - This exception is thrown when the result produced by 
                the operation is out of range. For example,

3. ValidationException - This exception is thrown when an input value is not valid. 
For example, if we enter an integer value in a field that expects a DateTime value, this exception is thrown.

4. ArgumentException - This exception is thrown when we provide one invalid argument in a method.
For example, when we pass an argument of a data type that doesn't match specified parameters during a method's call,
then this exception occurs. */

using System;
using System.IO; 

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string writeText = "Doodleblue file creation";
      File.WriteAllText("filename.txt", writeText);

      string readText = File.ReadAllText("filename.txt");
      Console.WriteLine(readText); 
      }
    }   
 }
 
 /* files are used to create the file and read the file and edit the file it is the program explainse
 it is first creating the file using keyword (WriteAllText) and we can read the file content using the keyword (ReadAllText)
 and there are some more commands can used,
AppendText()   --	Appends text at the end of an existing file
Copy()         --	Copies a file
Create() 	     -- Creates or overwrites a file
Delete() 	     -- Deletes a file
Exists()       --	Tests whether the file exists
ReadAllText()  -- Reads the contents of a file
Replace() 	   -- Replaces the contents of a file with the contents of another file
WriteAllText() --	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten. */

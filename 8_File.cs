// Working with files
/* 
AppendText()  -	Appends text at the end of an existing file
Copy()  -	Copies a file
Create()  -	Creates or overwrites a file
Delete()  -	Deletes a file
Exists()  -	Tests whether the file exists
ReadAllText() -	Reads the contents of a file
Replace()  -	Replaces the contents of a file with the contents of another file
WriteAllText()  - 	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
*/

// Write To a File and Read It

using System;
using System.IO;

namespace OOP{
    class Program{
        static void Main(string[] args){
            string writeText = "Hello World";
            File.WriteAllText("file.txt", writeText);
            
            string readText = File.ReadAllText("file.txt");
            Console.WriteLine(readText);
        }
    }
}

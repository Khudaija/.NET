// First program - Hello World

using System; 
    class Hello{
        static void Main(string[] args){
            Console.WriteLine("Hello World");
        }
    }

//Same as a first Program
using System; // that we can use classes from the System namespace
    namespace Hello{     //is used to organize your code, and it is a container for classes and other namespaces
        class Program{     //is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class
            static void Main(string[] args){    
                Console.WriteLine("Hello World");    //Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text
            }
        }
    }

// Input

using System;
    namespace Hello{
        class Program{
            static void Main(string[] args){
                Console.WriteLine("Hello World");
                Console.ReadLine();      // Input
                Console.WriteLine("Hello World");
            }
        }
    }

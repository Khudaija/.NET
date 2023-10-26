// Methods 

/* A method is a block of code which only runs when it is called.
You can pass data, known as parameters, into a method.
Methods are used to perform certain actions, and they are also known as functions.
Why use methods? To reuse code: define the code once, and use it many times. */

using System;

namespace myApp{
    public class Program{
        
        // Create a method
        static void myMethod(){
            Console.WriteLine("Method is Called...");
        }
        
        public static void Main(string[] args){
            
            // call a methode
            myMethod();
            
            //multiple time calling 
            
            myMethod();
            myMethod();
            
        }
    }
}

// Methode Parameters & Arguments

//Single Parammeter
using System;

namespace myApp{
    public class Program{
        
        static void myMethod(string name){
            Console.WriteLine(name + " is a Anna");
        }
        public static void Main(string[] args){
            myMethod("Anna");
        }
    }
}


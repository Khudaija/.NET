// OOP - Object-Oriented Programming

/* Procedural programming is about writing procedures or methods that perform operations on the data, 
while object-oriented programming is about creating objects that contain both data and methods. */

// Class - template: & Objectd - instance of class 

using System;

namespace OOP{
    class Car{
        
        string colour = "red";
        
        static void Main(string[] args){
            Car myObj = new Car();
            Console.WriteLine(myObj.colour);
        }
    }
}



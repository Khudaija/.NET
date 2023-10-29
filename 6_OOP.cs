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

// Multiple Object

using System;

namespace OOP{
    class Car{
        
        string colour = "red";
        
        static void Main(string[] args){
            
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.colour);
            Console.WriteLine(myObj2.colour);
        }
    }
}

// Multiple Class

using System;

namespace OOP{
    
    class Car{
        public string colour = "red";
    }
    
    class Program{
        
        static void Main(string[] args){
            
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.colour);
            Console.WriteLine(myObj2.colour);
        }
    }
}

// Class Member - fields

using System;

namespace OOP{
    class  Car{
        
        string colour = "red";
        int maxSpeed = 100;
        
        static void Main(string[] args){
            
            Car myObj = new Car();
            Console.WriteLine(myObj.colour);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}

// Class Member - field define in class and declare in main function

using System;

namespace OOP{
    class Car{
        string colour;
        int maxSpeed;
        
        static void Main(string[] args){
            
            Car myObj = new Car();
            myObj.colour = "red";
            myObj.maxSpeed = 100;
            
            Console.WriteLine(myObj.colour);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}

// Class Member - field creating multiple objects of one class - define in class and declare in main function

using System;

namespace OOP{
    class Car{
        string colour;
        int maxSpeed;
        
        static void Main(string[] args){
            
            Car myObj = new Car();
            myObj.colour = "red";
            myObj.maxSpeed = 100;
            
            Car BMW = new Car();
            BMW.colour = "Black";
            BMW.maxSpeed = 125;
            
            Console.WriteLine(myObj.colour);
            Console.WriteLine(BMW.colour);
        }
    }
}

// Class Member - field (Create Method)

using System;

namespace OOP{
    class Car{
        string colour;
        int maxSpeed;
        
        public void fulfil(){
            Console.WriteLine("Print class method");
        }
        static void Main(string[] args){
            
            Car myObj = new Car();
            myObj.fulfil();
        }
    }
}

// Constructors
/*special method that is used to initialize objects. The advantage of a constructor, 
is that it is called when an object of a class is created. It can be used to set initial values for fields 
constructor name must match the class name, and it cannot have a return type (like void or int)*/

using System;

namespace OOP{
    class Car{
        public string model;
        
        public Car(){
            model = "Mfc";
        }
        
        static void Main(string[] args){
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}

// Constructors Parameter

using System;

namespace OOP{
    class Car{
        public string model;
        
        public Car(string modelName){
            model = modelName;
        }
        
        static void Main(string[] args){
            Car myObj = new Car("Mfc");
            Console.WriteLine(myObj.model);
        }
    }
}


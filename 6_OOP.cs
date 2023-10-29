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

// Multiple constructor Parameters

using System;

namespace myApp{
    class Car{
        public string model;
        public string colour;
        public int year;
        
        public Car(string modelName, string modelColour, int modelYear){
            model = modelName;
            colour = modelColour;
            year = modelYear;
        }
        
        static void Main(string[] args){
            
            Car Ford = new Car("MFC", "Black", 1998);
            Console.WriteLine(Ford.model);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.colour);
        }
    }
}

// Access Modifier - all members of a class are private if you don't specify an access modifier

using System;

namespace OOP{
    class Car{
        private string fullname = "abc";
    }
    
    class Program{
        private string name = "xyz";
        
        static void Main(string[] args){

            // if access modifier is private then other class object is inaccessible due to its protection level
            /* Car myObj = new Car(); // Error
            Console.WriteLine(myObj.fullname);  */
            
            Program myObj1 = new Program();
            Console.WriteLine(myObj1.name);
        }
    }
}

// Properties (Get and Set) and Encapsulation
/* 
=>Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

- declare fields/variables as private
- provide public get and set methods, through properties, to access and update the value of a private field 

=> private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties

=> A property is like a combination of a variable and a method, and it has two methods: a get and a set method
*/

using System;

namespace OOP{
    class Person{
        private string name;
        
        public string Name{
            get {return name;}
            set {name = value;}
        }
    }
    
    class Program{
        static void Main(string[] args){
            
            Person myObj = new Person();
            myObj.Name = "SK";
            Console.WriteLine(myObj.Name);
        }
    }
}
// Properties (Get and Set) and Encapsulation
/* 
=>Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

- declare fields/variables as private
- provide public get and set methods, through properties, to access and update the value of a private field 

=> private variables can only be accessed within the same class (an outside class has no access to it). 
However, sometimes we need to access them - and it can be done with properties

=> A property is like a combination of a variable and a method, and it has two methods: a get and a set method
*/

using System;

namespace OOP{
    class Person{
        private string name;
        
        public string Name{
            get {return name;}
            set {name = value;}
        }
    }
    
    class Program{
        static void Main(string[] args){
            
            Person myObj = new Person();
            myObj.Name = "SK";
            Console.WriteLine(myObj.Name);
        }
    }
}

// Properties (Get and Set) and Encapsulation

using System;

namespace OOP{
    class Person{
        public string Name{
            get;
            set;
        }
    }
    
    class Program{
        static void Main(string[] args){
            
            Person myObj = new Person();
            myObj.Name = "SK";
            Console.WriteLine(myObj.Name);
        }
    }
}

// Inheritance 

/* 
it is possible to inherit fields and methods from one class to another.

Derived Class (child) - the class that inherits from another class
Base Class (parent) - the class being inherited from
*/

using System;

namespace OOP{
    class Vehicle{
        public string brand = "BMW";
        public void honk(){
            Console.WriteLine("Tuut, tuut!");
        }
    }
    
    class Car: Vehicle{
        public string modelName = "MFC";
    }
    
    class Program{
        
        static void Main(string[] args){
        
            Car myObj =  new Car();
        
            myObj.honk();
            Console.WriteLine(myObj.brand);
            Console.WriteLine(myObj.modelName);
        }
    }
}


// Enums

/* An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma */

using System;

namespace OOP{
    enum Level{
        Low,
        Medium,
        High
    }
    
    class Program{
        static void Main(string[] args){
            Level myVar = Level.Medium;
            
            Console.WriteLine(myVar);
        }
    }
}

// Enums inside a class

using System;

namespace OOP{
    
    class Program{
        
        enum Level{
            Low,
            Medium,
            High
        }
        
        static void Main(string[] args){
            Level myVar = Level.Medium;
            
            Console.WriteLine(myVar);
        }
    }
}


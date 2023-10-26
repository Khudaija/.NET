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

// Multiple Parammeter
using System;

namespace myApp{
    public class Program{
        
        static void myMethod(string name, int age){
            Console.WriteLine(name + " is a " + age + " year old.");
        }
        public static void Main(string[] args){
            myMethod("Anna", 22);
            myMethod("Johne", 18);
        }
    }
}

// Default Parameter Value

using System;

namespace myApp{
    public class Program{
        
        static void myMethod(string country = "India"){
            Console.WriteLine(country);
        }
        
        public static void Main(string[] args){
            
            myMethod("UK");
            myMethod("US");
            myMethod();
        }
    }
}

// Return Values

using System;

namespace myApp{
    public class Program{
        
        static int myFirstMethod(int y){
            return 5 + y;
        }
        
        static int mySecondMethod(int x, int y){
            return x + y;
        }
        
        static int myThirdMethod(int x, int y){
            int z = x + y;
            return z;
        }
        
        static int myForthMethod(int x, int y){
            return x + y;
        }
        
        public static void Main(string[] args){
            
            Console.WriteLine(myFirstMethod(5));
            Console.WriteLine(mySecondMethod(5,5));
            Console.WriteLine(myThirdMethod(5,5));
            
            int z = myForthMethod(5, 5);
            Console.WriteLine(z);
        }
    }
}

// Named Arguments

/* It is also possible to send arguments with the key: value syntax.
That way, the order of the arguments does not matter. */

using System;

namespace myApp{
    public class Program{
        
        static void myMethod(string ch1, string ch2, string ch3){
            Console.WriteLine("The smallest is " + ch3);
        }
        public static void Main(string[] args){
            myMethod(ch3: "SK", ch2:"AP", ch1:"KP");
            
        }
    }
}

// Method Overloading - multiple methods can have the same name with different parameters

using System;

namespace myApp{
    public class Program{
        
        static int myMethod(int x, int y){
            return x + y;
        } 
        
        static double myMethod(double x, double y){
            return x + y;
        }
        
        public static void Main(string[] args){
        
            int myNum1 = myMethod(2,4);
            double myNum2 = myMethod(2.3, 3.4);
            
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}

// Example

using System;

namespace myApp{
    public class Program{
        
        static void myMethod(int x){
            
            for(int i = 1;  i <= x; i++){
                if(i == 4){
                    continue;
                }
                
                Console.WriteLine(i);
            }
        }
        
        public static void Main(string[] args){
            myMethod(10);
        }
    }
}

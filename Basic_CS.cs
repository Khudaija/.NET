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

//Variables

using System;
namespace Variables{
    public class Program{
        public static void Main(string[] args){
            /*const int Age = 22; // unchangeable and read-only
            Age = 23; //error */

            /*char sWord = I; // its used for single character
            Console.WriteLine(sWord);*/
            
            int Age = 22; // float, double
            string Name = "Khudaija"; 
            string SrName = " Pinjari";
            Console.WriteLine("My Name is " + Name + SrName + " and I am " + Age + " years old."); 
        }
    }
}

// DataType

using System;
namespace DataType{
    public class Program{
        public static void Main(string[] args){
            int Age = 22;
            Console.WriteLine(Age);
            double ExactAge = 22.1D;
            Console.WriteLine(ExactAge);
            string Name = "Khudaija";
            Console.WriteLine(Name);
            char SrName = 'P';
            Console.WriteLine(SrName);
            bool myBool = true;
            Console.WriteLine(myBool);
        }
    }
}

// Type Casting

using System;

namespace TypeCasting{
    public class Program{
        public static void Main(string[] args){
            
            //implicit casting - done automatically when passing a smaller size type to a larger size type
            
            /*int age = 22;
            double Dage = age;
            Console.WriteLine(age);
            Console.WriteLine(Dage);*/
            
            //explicit castring - manually by placing the type in parentheses in front of the value
            
            /*double age = 22.1;
            int myage = (int) age;
            Console.WriteLine(age);
            Console.WriteLine(myage); */
            
            /* Type Conversion Method - convert data types explicitly by using built-in methods, 
            such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long) */
            
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            
        }
    }
}


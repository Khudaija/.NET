//  print Hello and your name in a separate line
using System;
namespace Practices{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Eneter Name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Hello");
            Console.WriteLine(name);
        }
    }
}


// print the sum of two numbers  
using System;
namespace Practices{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(firstNum + secondNum);
        }
    }
}


// print the result of dividing two numbers
using System;
namespace Practices{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(firstNum / secondNum);
        }
    }
}

// swap two numbers with 3rd variable
using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            int a = 3;
            int b = 4;
            
            Console.WriteLine("Before Swapping : " + a + " , " + b);
            
            int temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine("After Swapping : " + a + " , " + b);
        }
    }
}

// swap two numbers without 3rd variable
using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            int a = 3;
            int b = 4;
            
            Console.WriteLine("Before Swapping : " + a + " , " + b);
            
            a = a + b;
            b = a - b;
            a = a - b;
            
            Console.WriteLine("After Swapping : " + a + " , " + b);
        }
    }
}

// multiplication of three numbers entered by the user
using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter First Number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Multiplication of three numbers: ");
            Console.WriteLine(firstNum * secondNum * thirdNum);
        }
    }
}

// adding, subtracting, multiplying and dividing two numbers entered by the user
using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter First Number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Adding: " + firstNum + secondNum);
            Console.WriteLine("Substracting: " + (firstNum - secondNum));
            Console.WriteLine("Multiplication: " + firstNum * secondNum);
            Console.WriteLine("Dividing: " + firstNum / secondNum);
            Console.WriteLine("Module: " + firstNum % secondNum);
        }
    }
}

// multiplication table of a number as input
using System;

namespace Practice{
    class Program{
        static void Main(string[] args){
            int n = 5;
            
            for(int i = 1; i<=10; i++){
                
                int mul = i * n;
                Console.WriteLine(n + " X " + i + " = " + mul );
            }
        }
    }
}

// takes four numbers as input to calculate and print the average
using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter four numbers: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());
            
            int sum = (n1 + n2 + n3 + n4)/4;
            Console.WriteLine("Average: " + sum);
        }
    }
}

//  takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z. 
/* 
Enter first number - 5
Enter second number - 6
Enter third number - 7
*/
using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int z = Convert.ToInt32(Console.ReadLine());
            
            int firstEquation = (x + y)*z;
            Console.WriteLine("(x + y).z = " + firstEquation);
            
            int secondEquation = x * y + y * z;
            Console.WriteLine("x.y + y.z = " + secondEquation);
            
        }
    }
}

// takes an age (for example 20) as input and prints something like 
//"You look older than 20"
using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            int age = 20;
            if(age>20){
                Console.WriteLine("You are below 18.");
            }
            else{
                Console.WriteLine("Your look older than 20.");
            }
        }
    }
}

// convert Celsius degrees to Kelvin and Fahrenheit
using System;
namespace Problem{
    class prog{
        static void Main(string[] args){
            double Celsius = 25;
            
            double Kelvin = Celsius + 273.15;
            Console.WriteLine("Kelvin: " + Kelvin);
            
            double Fahrenheit = (Celsius * (9/5)) + 32;
            Console.WriteLine("Fahrenheit: " + Fahrenheit);
        }
    }
}

//removes a specified character from a non-empty string using the index of a character
using System;
using System.Collections.Generic;
namespace problem{
    class Prog{
        // Function to remove a character at the specified index
        public static string remove_char(string str, int n){
            return str.Remove(n,1);  // Using Remove method to eliminate the character at index n
        }
        
        static void Main(string[] args){
            Console.WriteLine(remove_char("w3school", 2));
        }
    }
}

// Display three letters in reverse order
using System;
namespace Problem{
    class Prog{
        static void Main(string[] args){
            char a1, a2, a3;
            
            Console.Write("1... ");
            a1 = Convert.ToChar(Console.ReadLine());
            
            Console.Write("2... ");
            a2 = Convert.ToChar(Console.ReadLine());
            
            Console.Write("3... ");
            a3 = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("{2} {1} {0} " , a1, a2, a3);
        }
    }
}

// takes a number and a width also a number. It then displays a triangle of that width using that number
using System;
namespace Problem{
    class Prog{
        static void Main(string[] args){
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for(int i = n; i>=1; i--){
                for(int j=1; j<=i; j++){
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


//takes userid and password as input (string type). After 3 unsuccessful attempts, the user will be rejected
using System;
namespace User_Pass{
    class Problem{
        static void Main(string[] args){
            string username = "Khudaija";
            string pass = "abc@123";
            
            string Enter_Username = Console.ReadLine();
            string Enter_Pass = Console.ReadLine();
            
            if(username == Enter_Username || pass == Enter_Pass){
                Console.WriteLine("Welcome...");
            }
            else{
                Console.WriteLine("Invalid!");
            }
        }
    }
}


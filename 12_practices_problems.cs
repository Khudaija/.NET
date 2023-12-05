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

//takes userid and password as input (string type). After 3 unsuccessful attempts, the user will be rejected
using System;
namespace User_Pass{
    class Problem{
        static void Main(string[] args){
            string username, password;
            int ctr = 0 , dd = 0;
                Console.Write("\n\nCheck username and password :\n");
	            Console.Write("N.B. : Defaule username and password is : username and password\n");
                Console.Write("---------------------------------\n"); 
                
            do{
                Console.Write("Enter username: ");
                username = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                
                if(username == "username" && password == "password"){
                    dd = 1;
                    ctr = 3;
                }
                else{
                    dd = 0;
                    ctr++;
                }
            }
            while((username != "username" || password != "password") && (ctr !=3));
            
                if(dd == 0){
                    Console.Write("\nLogin attemp more than three times. Try later!\n\n");
                }
                else
                if(dd == 1){
                    Console.Write("\nPassword entered successfull!\n\n");
                }
        }
    }
}

// takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation

using System;
namespace Program{
    class Problem{
        static void Main(string[] args){
            int x, y; 
            char operation;
            
            Console.Write("Enter the x: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the y: ");
            y = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input Operator(+,-,*,x,/): ");
            operation = Convert.ToChar(Console.ReadLine());
            
            if(operation == '+'){
                Console.WriteLine("{0} + {1} = {2}", x,y, x+y);
            }
            else if(operation == '-'){
                Console.WriteLine("{0} - {1} = {2}", x,y, x-y);
            }
            else if((operation == '*') || (operation == 'x')){
                Console.WriteLine("{0} * {1} = {2}", x,y, x*y);
            }
            else if(operation == '/'){
                Console.WriteLine("{0} / {1} = {2}", x,y , x/y);
            }
            else{
                Console.WriteLine("Wrong Charachter...");
            }
        }
    }
}

// takes the radius of a circle as input and calculates the perimeter and area of the circle

using System;
namespace Program{
    class Problem{
        static void Main(string[] args){
            double r, per_cir;
            double PI = 3.14;
            Console.Write("Enter the radius: ");
            r = Convert.ToInt32(Console.ReadLine());
            per_cir = 2 * PI * r;
            
            Console.WriteLine("Calculates the perimeter and area of the circle: {0}", per_cir);
        }
    }
}

// display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5)

using System;
namespace Program{
    class Problem{
        static void Main(string[] args){
            int x, y;
            Console.WriteLine("Enter the value of y in range of -5 to +5");
            y = Convert.ToInt32(Console.ReadLine());
            if(y>=-5 || y<=5){
                x = y*y + 2*y + 1;
                Console.WriteLine(x);
            }
            else{
                Console.WriteLine("Please enter the value of y in range of -5 to +5");
            }
        }
    }
}

// display certain values of the function x = y^2 - 2y + 1 (using integer numbers for y, ranging from -5 to +5)

using System;
namespace Program{
    class Problem{
        static void Main(string[] args){
            int x, y;
            
            Console.WriteLine("x = y^2 - 2y + 1");
            Console.WriteLine();
            
            for(y=-5; y<=5; y++){
                x = y * y - 2 * y + 1;
                Console.WriteLine("y = {1}; x = {1}^2 - 2 *{1} + 1 = {0}", x,y);
                
            }
        }
    }
}

// takes distance and time as input and displays speed in kilometres per hour and miles per hour

using System;
namespace Program{
    class Problem{
        static void Main(string[] args){
            double timeSec, mps, kph, mph;
            double hour, min, sec;
            double distance;
        
            Console.Write("Enter the hour: ");
            hour = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the min: ");
            min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the sec: ");
            sec = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance(meter): ");
            distance = Convert.ToDouble(Console.ReadLine());
        
            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance/1000) / (timeSec / 3600);
            mph = kph / 1.609;
        
            Console.WriteLine("timeSec: " + timeSec);
            Console.WriteLine("mps: " + mps);
            Console.WriteLine("kph: " + kph);
            Console.WriteLine("mph: " + mph);
        }
        
    }
}


// accept two integers and check whether they are equal or not

using System;
namespace Program{
    class Problem{
        static void Main(string[] args){
            Console.Write("Enter the 1st number: ");
            int first_Num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            int second_num = Convert.ToInt32(Console.ReadLine());
            
            if(first_Num == second_num){
                    Console.WriteLine("{0} and {1} are equal.", first_Num,second_num);
            }
            else{
                Console.WriteLine("{0} and {1} are not equal.", first_Num,second_num);
            }
        }
    }
}

// takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere
using System;
namespace Program{
    class problem{
        static void Main(string[] args){
            double V, r;
            double PI = 3.1415926535D;
            
            Console.Write("Enter the radius: ");
            r = Convert.ToInt32(Console.ReadLine());
            
            double S = 4 * PI * (r * r); 
            
            V = (4f/3f) * PI * (r * r * r);
            
            Console.WriteLine("Calculate the surface and volume of te shere: " + V + " And " + S);
        }
    }
}


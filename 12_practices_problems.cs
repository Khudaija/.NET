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


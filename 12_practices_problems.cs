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


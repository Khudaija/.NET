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

// print the sum of two numbers  Convert.ToInt32

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


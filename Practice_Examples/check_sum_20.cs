// check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20

using System;

namespace Program{
    class Problem{
        static void Main(string[] args){
            int a, b;
            
            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            int sum = a + b;
            
            Console.WriteLine((sum == 20) || (a == 20) || (b == 20));
        }
    }
}

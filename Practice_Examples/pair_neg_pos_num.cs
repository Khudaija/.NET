//  check a pair of integers and return true if one is negative and one is positive

using System;

namespace Program{
    class Problem{
        static void Main(string[] args){
            int x, y;
            
            Console.Write("Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Check a pair of integers and return true if one is negative and one is positive");
            
            Console.WriteLine((x>=0 && y<=0) || (x<=0 && y>=0));
        }
    }
}

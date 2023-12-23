// compute the sum of an integer's digits

using System;

namespace Program{
    class Problem{
        static void Main(string[] args){
            Console.Write("Enter the Number: ");
            
            int n = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;
            
            while(n != 0){
                sum += n % 10;
                n /= 10;
            }
            
            Console.WriteLine("The sum of an integer's digits: " + sum);
        }
    }
}

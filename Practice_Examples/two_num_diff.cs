/*
get the absolute value of the difference between two given numbers. 
Return double the absolute value of the difference if the first number is greater than the second number
*/

using System;

namespace Program{
    class Program{
        public static int result(int a, int b){
            if(a>b){
                return (a - b) * 2;
            }
            return (b-a);
        }
        static void Main(string[] args){
            Console.WriteLine(result(45, 35));
            Console.WriteLine(result(35, 45));
        }
    }
}

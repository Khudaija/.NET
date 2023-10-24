// String

using System;

namespace myApp{
    public class Program{
        public static void Main(string[] args){
            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine(text.Length); // length
            
            string greeting = "Good Morning";
            Console.WriteLine(greeting.ToUpper()); //upper case
            Console.WriteLine(greeting.ToLower()); // lower case
        }
    }
}


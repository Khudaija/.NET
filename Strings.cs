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

// String Concatenation

using System;

namespace myApp{
    public class Program{
        public static void Main(string[] args){
            string firstName = "Khudaija";
            string secondName = " Pinjari";
            
            // Direct add string
            Console.WriteLine(firstName + secondName);
            
            //Concat function use
            string name = string.Concat(firstName, secondName);
            Console.WriteLine(name); 
            
            // numbers add in string 
            string x = "13";
            string y = "14";
            string z = x + y;
            Console.WriteLine(z);
        }
    }
}



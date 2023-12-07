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


// Interpolation
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            string firstName = "Khudaija";
            string secondName = "Pinjari";
            
            string name = $"My name is {firstName} {secondName}";
            Console.WriteLine(name);
        }
    }
}


// Access String
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            string text = "My name is John.";
            Console.WriteLine(text[0]); // indexing
            
            Console.WriteLine(text.IndexOf("n"));
            
            // after indexing all string is print
            int charPos = text.IndexOf("n");
            string nextText = text.Substring(charPos); 
            Console.WriteLine(nextText);
        }
    }
}

// Special Characters - \n, \t, \b
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            string text = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(text);
            
            string text2 = "It\'s alright.";
            Console.WriteLine(text2);
            
            string text3 = "The character \\ is called backslash.";
            Console.WriteLine(text3);
            
        }
    }
}


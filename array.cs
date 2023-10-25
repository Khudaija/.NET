// Array

using System;

namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            //Access the single element of an array
            string[] cars = {"BMW", "8hundred", "ford"};
            Console.WriteLine(cars[0]);
            
            // change an array element
            cars[0] = "opel";
            Console.WriteLine(cars[0]);
            
            // array length
            Console.WriteLine(cars.Length);
        }
    }
}

// other way to create array

using System;

namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            //declare an array
            string[] cars;
            
            // add value, using new keyword
            cars = new string[] {"8hundred", "ford", "BMW"};
            
            Console.WriteLine(cars[0]);
            
        }
    }
}


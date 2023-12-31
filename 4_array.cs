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


//loop through an array
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            string[] cars = {"8hundred", "ford", "BMW"};
            
            for(int i=0; i<cars.Length; i++){
                Console.WriteLine(cars[i]);
            }
        }
    }
}


// Sort Arrays
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            // sorting in string array
            string[] cars = {"8hundred", "ford", "BMW"};
            Array.Sort(cars);
            foreach(string i in cars){
                Console.WriteLine(i);
            }
            
            // sorting in integiral array
            int[] num = {1, 5, 8, 2, 0};
            Array.Sort(num);
            foreach(int i in num){
                Console.WriteLine(i);
            }
            
        }
    }
}


// using linq
using System;
using System.Linq;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            int[] num = {5, 1, 3, 7, 0 };
            
            Console.WriteLine(num.Max()); // largest number
            Console.WriteLine(num.Min()); // smallest number
            Console.WriteLine(num.Sum());  // sum
            
        }
    }
}


//Multidimension Array
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            //create 2D dimension array
            int[,] num = {{3, 5, 2}, {1, 6, 9}};
            
            //Access the 2D array
            Console.WriteLine(num[0,2]);
            
            //change element
            num[0,0] = 8;
            Console.WriteLine(num[0,0]);
            
        }
    }
}


// loop through 2d array
using System;
namespace myApp{
    public class Program{
        public static void Main (string[] args){
            
            int[,] num = {{3, 9, 6}, {4, 7, 1}};
            
            foreach(int i in num){
                Console.WriteLine(i);
            }
        }
    }
}


// loop through 2d array get length
using System;
namespace myApp{
    public class Program{
        public static void Main (string[] args){
            
            int[,] num = {{3, 9, 6}, {4, 7, 1}};
            
            for(int i = 0; i < num.GetLength(0); i++){
                for(int j = 0; j < num.GetLength(1); j++){
                    Console.WriteLine(num[i, j]);
                }
            }
        }
    }
}

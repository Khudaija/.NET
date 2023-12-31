// if, else if & else....
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            Console.WriteLine("Enter your age ");
            int Age = Convert.ToInt32(Console.ReadLine());
            
            if(Age==18){
                Console.WriteLine("Make Your Voter ID Card.");
            }
            else if(Age >= 18){
                Console.WriteLine("Give Your Valuable Vote.");
            }
            else{
                Console.WriteLine("Your Age is invalid for Vote.");
            }
            
        }
    }
}


// short hand if else
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            int age = 22;
            
            //          Conditon      if stat    else stat
            string result = (age>18) ? "Valid" : "Invalid";
            
            Console.WriteLine(result);
        }
    }
}


// Switch
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            int day = 4;
            
            switch (day){
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                    
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                    
                default:
                    Console.WriteLine("Monday, Tuesday, Wednesday, Thursday, & Friday");
                    break;
            }
        }
    }
}


// While
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            int i = 2; // initialization
            
            while(i<10){  // condition
                Console.WriteLine(i);
                i++; // updation
            }
        }
    }
}


// While
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            int i = 2; // initialization
            
            do{
                Console.WriteLine(i);
                i++; // updation
            }while(i<=10);  //condition
        }
    }
}


// for loop
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            for(int i = 10; i>=1; i--){
                Console.WriteLine(i);
            }
        }
    }
}


// nested loop
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            
            for(int i = 10; i>=1; i--){
                for(int j = 1; j<=3; j++){
                    Console.WriteLine(i + "  " + j);
                }
            }
        }
    }
}


// for each loop - is used exclusively to loop through elements in an array
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            string[] cars = {"BMW", "800", "ford"};
            
            foreach(string i in cars){
                Console.WriteLine(i);
            }
        }
    }
}


// break
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i);
                
                if(i==4){ // condition for use break function
                    break;
                }
            }
        }
    }
}


// continue
using System;
namespace myApp{
    public class Program{
        public static void Main(string[] args){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i);
                
                if(i==4){ // condition for use continue function
                    Console.WriteLine("half quater");
                    continue;
                }
            }
        }
    }
}

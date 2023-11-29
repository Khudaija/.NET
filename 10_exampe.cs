// Star Pattern
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            
            for(int i = 0; i<4; i++){
                for(int j = 0; j<4; j++){
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}

// Pattern
using System;

namespace Pattern{
    class Program{
        static void Main(string[] args){
            
            int n = 4;
            int m = 4;
            
            for(int i = 0; i < n; i++){
                for(int j = 0; j < m; j++){
                    if(i == 0 || j ==0 || i == n-1 || j == m-1){
                        Console.Write("*");
                    }
                    else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

//star pattern 
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            
            int n = 5; 
            
            for(int i=0; i<n; i++){
                for(int j=0; j<=i; j++){
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}

//star pattern
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n=5;
            
            for(int i=n; i>=1; i--){
                for(int j=1; j<=i; j++){
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}

// Star Pattern

using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n=4;
            
            for(int i= n; i >= 1; i--){
                for(int j=1; j<i; j++){
                    Console.Write("   ");
                }
                for(int j=0; j<=n-i; j++){
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}

// number pattern
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n=4;
            for(int i=1; i<=n; i++){
                for(int j=1; j<=i; j++){
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

// number pattern
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n = 4;
            
            for(int i=n; i>=1; i--){
                for(int j=1; j<=i; j++){
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

// binary square pattern
using System;

namespace pattern{
    class program{
        static void Main(string[] args){
            int n = 4;
            for(int i = 1; i <= n; i++){
                for(int j = 1; j <= n; j++){
                    int sum = i + j;
                    if(sum % 2 == 0){
                        Console.Write(1 + " ");
                    }
                    else{
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

// binary triangle pattern
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n = 4;
            
            for(int i = 1; i <= n; i++){
                for(int j = n; j >= i; j--){
                    int sum = i + j;
                    if(sum % 2 == 0){
                        Console.Write(1 + " ");
                    }
                    else{
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

// binar triangle pattern
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n = 4;
            for(int i = 1; i <= n; i++){
                for(int j = n ; j >= n-i; j--){
                    Console.Write(" ");
                }
                for(int j = n; j >= i; j--){
                    int sum = i + j;
                    if(sum % 2 == 0){
                        Console.Write(1 + " ");
                    }
                    else{
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

// binar triangle pattern
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n = 4;
            for(int i = 1; i <= n; i++){
                for(int j = n ; j >= n-i; j--){
                    Console.Write("  ");
                }
                for(int j = n; j >= i; j--){
                    int sum = i + j;
                    if(sum % 2 == 0){
                        Console.Write(1 + " ");
                    }
                    else{
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

// alphbetically rectangle pattern
using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n = 4;
            
            for(int i=1; i<=n; i++){
                for(int j=1; j<= n-i; j++){
                    Console.Write(" ");
                }
                for(int j=1; j<= i; j++){
                    Console.Write("A ");
                }
                Console.WriteLine();
            }
        }
    }
}

// convert Celsius degrees to Kelvin and Fahrenheit
using System;

namespace Problem{
    class prog{
        static void Main(string[] args){
            double Celsius = 25;
            
            double Kelvin = Celsius + 273.15;
            Console.WriteLine("Kelvin: " + Kelvin);
            
            double Fahrenheit = (Celsius * (9/5)) + 32;
            Console.WriteLine("Fahrenheit: " + Fahrenheit);
        }
    }
}

//removes a specified character from a non-empty string using the index of a character
using System;
using System.Collections.Generic;

namespace problem{
    class Prog{
        // Function to remove a character at the specified index
        public static string remove_char(string str, int n){
            return str.Remove(n,1);  // Using Remove method to eliminate the character at index n
        }
        
        static void Main(string[] args){
            Console.WriteLine(remove_char("w3school", 2));
        }
    }
}

// Display three letters in reverse order
using System;
namespace Problem{
    class Prog{
        static void Main(string[] args){
            char a1, a2, a3;
            
            Console.Write("1... ");
            a1 = Convert.ToChar(Console.ReadLine());
            
            Console.Write("2... ");
            a2 = Convert.ToChar(Console.ReadLine());
            
            Console.Write("3... ");
            a3 = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("{2} {1} {0} " , a1, a2, a3);
        }
    }
}

// takes a number and a width also a number. It then displays a triangle of that width using that number
using System;
namespace Problem{
    class Prog{
        static void Main(string[] args){
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for(int i = n; i>=1; i--){
                for(int j=1; j<=i; j++){
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

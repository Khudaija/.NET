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

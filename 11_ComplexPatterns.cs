//buttefly star pattern

using System;

namespace pattern{
    class Program{
        static void Main(string[] args){
            int n=4;
            for(int i=1; i<=n; i++){
                for(int j=1; j<=i; j++){
                    Console.Write(" * ");
                }
                
                int space = 2 * (n-i);
                for(int j=1; j<=space; j++){
                    Console.Write("   ");
                }
                
                for(int j=1; j<=i; j++){
                    Console.Write(" * ");
                }
                
                Console.WriteLine();
            }
            
            for(int i=n; i>=1; i--){
                for(int j=1; j<=i; j++){
                    Console.Write(" * ");
                }
                
                int space = 2*(n-i);
                for(int j=1; j<=space; j++){
                    Console.Write("   ");
                }
                
                for(int j=1; j<=i; j++){
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
            int n = 5;
            
            for(int i=n; i>=1; i--){
                for(int j=1; j<=i-1; j++){
                    Console.Write("   ");
                }
                for(int j=1; j<=n; j++){
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}

// star pattern

using System;

namespace Pattern{
    class Program{
        static void Main(string[] args){
            int n = 5;
            
            for(int i=1; i <= n; i++){
                for(int j=1; j<=n-i; j++){
                    Console.Write(" ");
                }
                for(int j=i; j>=1; j--){
                    Console.Write(j );
                }
                for(int j=2; j<=i;j++){
                    Console.Write(j );
                }
                
                Console.WriteLine();
            }
        }
    }
}


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

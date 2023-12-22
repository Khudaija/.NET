// print odd numbers from 1 to 99. Prints one number per line

using System;

namespace Program{
    class Problem{
        static void Main(string[] args){
            int n = 100;
            
            for(int i=0; i<=n; i++){
                if(i % 2 !=0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}

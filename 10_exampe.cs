// Star Pattern

using System;

namespace OOP{
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

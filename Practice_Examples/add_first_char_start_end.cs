//create a string from a given string (length 1 or more) with the first character added at the front and back4

using System;

namespace Program{
    class Problem{
        static void Main(string[] args){
            string str;
            Console.Write("Enter the string: ");
            str = Console.ReadLine();
            
            if (str.Length>=1){
                var s = str.Substring(0,1);
                Console.WriteLine(s+str+s);
            }
        }
    }
}

// create a new string from a given string where the first and last characters change their positions
using System;
using System.Collections.Generic;
namespace Program{
    class Problem{
        public static string first_last(string ustr){
            return ustr.Length>1 
            ? ustr.Substring(ustr.Length-1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0,1)
            :ustr;
            
        }
        
        static void Main(string[] args){
            Console.WriteLine(first_last("w3school"));
        }
    }
}

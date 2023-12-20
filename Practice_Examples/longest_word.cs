//  find the longest word in a string

using System;

namespace Program{
    class Problem{
        static void Main(string[] args){
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            
            string word = "";
            int ctr = 0;
            
            foreach(String s in words){
                if(s.Length>ctr){
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
        }
    }
}

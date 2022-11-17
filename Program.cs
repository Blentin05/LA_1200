using System;
using System.Collections.Generic;


namespace vocabulary retrieval system
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            
                List<string> words = new List<string>();
            words.Add("cat");
            words.Add("dog");
            words.Add("one");
            words.Add("two");
            words.Add("three");
            words.Add("four");
            words.Add("five");
            words.Add("six");
            words.Add("seven");
            
                List<string> translation  = new List<string>();
           
            foreach (string name in words)
                {
                    Convert.ToString(words);
                    Console.WriteLine(name);
                    Console.ReadLine();
                    if (words[0] == "Katze")
                    {
                        Console.WriteLine("right");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }

                }
            
           

            Console.ReadKey();
            
            
               
            
        }
    }
}     

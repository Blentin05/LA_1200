using System;
using System.Collections.Generic;

namespace Prk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> woerter = new List<string>();
            woerter.Add("cat"); 
            woerter.Add("dog"); 
            woerter.Add("one");
            woerter.Add("two");
            woerter.Add("three");
            woerter.Add("four");
            woerter.Add("five");
            woerter.Add("six");
            woerter.Add("seven"); 
           
            foreach (string name in woerter)
            {
                Convert.ToString(woerter);
                Console.WriteLine(name);
                Console.ReadLine();         
            }

            if (woerter[0] == "Katze")
            {

                Console.WriteLine("Richtig");
            }
            else
            {
                Console.WriteLine("falsch");
            }
           
            Console.ReadKey();





        }
    }
}      
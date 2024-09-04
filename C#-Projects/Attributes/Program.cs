//Attributes in C#.
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;


namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(10, 20);
            Calculator.Add(new List<int>(){10, 20, 30, 40,50});
        }
    }
    class Calculator 
    {
        [Obsolete("Use(Add(List<int>Numbers)Method")]
        public static int Add(int Number1, int Number2)
        {
            return Number1 + Number2;  
        }

        public static void Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int Number in Numbers)
            {
                Sum += Number;
            }
            Console.WriteLine($"Sum of Numbers = {Sum}");
        }
    }
   
}

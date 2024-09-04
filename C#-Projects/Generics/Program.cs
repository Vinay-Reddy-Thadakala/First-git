using System;
using System.Collections.Generic;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator C =new Calculator();
            bool Result = C.Action<string>("Vinay", "Vinay");
            if (Result) 
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equals");
            }
        }
    }
    public class Calculator//We can also make the class generic if we want to make all the methods to accept any type of data.
    {
        public bool Action<T>(T Value1, T Value2)//here we used generic concept to make this method to accept any type of data.
        {
            return Value1.Equals(Value2);
        }
    }
}

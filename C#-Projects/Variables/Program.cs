// C# program to demonstrate the  
// Initialization of Variable
using System;

namespace Variables
{
    class Initialization
    {
        // only declaration, compiler will  
        // provide the default value 0 to it 
        int y;
        static void Main()
        {                                                         
            CompileTimeInitialization();
            RunTimeInitialization();
        }

        static void CompileTimeInitialization()
        {
            Console.WriteLine("Compile Time Initialization");
            // Compile Time Initialization of variable 'x' 
            // Assigning value 24 to x 
            int x = 24;

            // printing the value 
            Console.WriteLine("Value of x is " + x);

            // creating object to access the variable y 
            Initialization I = new Initialization();

            // printing the value 
            Console.WriteLine("Value of y is " + I.y);
        }

        static void RunTimeInitialization()
        {
            Console.WriteLine("Run Time Initialization");
            Console.WriteLine("Enter Any Value");
            // Value will be taken from user  
            // input and assigned to variable 
            // num 
            int num = Convert.ToInt32(Console.ReadLine());

            // printing the result 
            Console.WriteLine("Value of num is " + num);
        }
    }
}

using System;

namespace Reading_Writing
{
    class ToConsole
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Your Name");
            string UserName = Console.ReadLine();
            Console.WriteLine("Hello " + UserName); //Using Cancatenation.
            Console.WriteLine("Hello {0}", UserName); //Using Placeholder.
        }
    }
}

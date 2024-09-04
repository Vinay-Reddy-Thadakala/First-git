using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            OverLoad(0, 1);
            OverLoad(0, "One");
            OverLoad("One", 1);
            OverLoad(0, 1, "One");

        }

        public static void OverLoad(int Over, int Load)
        {
            Console.WriteLine("This is OverLoad Method with two same type Parameters");
        }
        public static void OverLoad(int Over, string Load)
        {
            Console.WriteLine("This is OverLoad Method with two different type Parameters");
        }
        public static void OverLoad(string Over,int Load)
        {
            Console.WriteLine("This is OverLoad Method with two different type Parameters");
        }
        public static void OverLoad(int Over, int Load, string Method)
        {
            Console.WriteLine("This is OverLoad Method with three parameters");
        }
        
    }

}

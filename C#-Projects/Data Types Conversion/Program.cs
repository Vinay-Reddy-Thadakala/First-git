//Data types Conversion in C#.
using System;

namespace Data_Types_Conversion
{
    class ImplicitExplicit
    {
        static void Main()
        {
            ImplicitConversion();
            ExplicitConversion();
            TypeConversionMethods();
            ParseMethod();
            TryParseMethod();
        }

        static void ImplicitConversion()
        {
            int i = 25;
            double d = i;
            Console.WriteLine("Implicit Conversion: {0}",i);
            Console.WriteLine("Implicit Conversion: {0}",d);
        }

        static void ExplicitConversion()
        {
            double D = 5.14254;
            int I = (int)D;
            Console.WriteLine("Explicit Conversion",D);
            Console.WriteLine("Explicit Conversion",I);
        }

        static void TypeConversionMethods()
        {
            Console.WriteLine("Using type-Conversionn method");
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }

        static void ParseMethod()
        {
            Console.WriteLine("Using parse method");
            string s = "100";
            int i = int.Parse(s);
            Console.WriteLine(i);
        }

        static void TryParseMethod()
        {
            Console.WriteLine("Using try-parse method");
            string S = "100VIN";
            int result;
            bool sucessful = int.TryParse(S, out result);
            Console.WriteLine("Using try-Parse method: {0}",sucessful);
        }
   
    }
}

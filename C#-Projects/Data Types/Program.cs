//Datatypes in C#.
using System;

namespace Data_Types
{
    class ValueDataTypes
    {
        static void Main()
        {
            IntegralDataTypes();
            FloatingPointTypes();
            DecimalDataTypes();
            CharacterDataTypes();
            BooleanDataTypes();
        } 
        static void IntegralDataTypes()
        {
            Console.WriteLine("Range of integral data types");
            Console.WriteLine("byte range is from: {0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("sbyte range is from: {0} to {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("short range is from: {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("ushort range is from: {0} to {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int range is from: {0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint range is from: {0} to {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("long range is from: {0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong range is from: {0} to {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Example on integral types");
            byte a = 255;
            Console.WriteLine("byte = " + a);
            sbyte b = 127;
            Console.WriteLine("sbyte = " + b);
            short c = 2541;
            Console.WriteLine("short = " + c);
            ushort d = 54254;
            Console.WriteLine("ushort = " + d);
            int e = 54444554;
            Console.WriteLine("int = " + e);
            uint f = 5445455;
            Console.WriteLine("uint = " + f);
            long g = 5656656444456;
            Console.WriteLine("long = " + g);
            ulong h = 54545444544545;
            Console.WriteLine("ulong = " + h);
        }    
        static void FloatingPointTypes()    
        {
            Console.WriteLine("Range of floating point types");
            Console.WriteLine("float range is from: {0} to {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double range is from: {0} to {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Example on floating point types");
            float i = 1.1122211f;
            Console.WriteLine("float = " + i);
            double j = 1.665655925241638d;
            Console.WriteLine("double = " + j);
        }
        static void DecimalDataTypes()
        {
            Console.WriteLine("Range of decimal data type");
            Console.WriteLine("decimal range is from: {0} to {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("Example for decimal type");
            decimal k = 1.564445241637895124521235641236m;
            Console.WriteLine("decimal = " + k);
        }
        static void CharacterDataTypes()
        {
            Console.WriteLine("Range of character data type");
            Console.WriteLine("character range is from: {0} to {1}", char.MinValue, char.MaxValue);
            Console.WriteLine("Exampla on character type");
            char l = 'v';
            Console.WriteLine("character = " + l);
        }
        static void BooleanDataTypes()
        {
            Console.WriteLine("boolean data type");
            Console.WriteLine("Example on boolean type");
            bool m = true;
            Console.WriteLine("boolean = " + m);
        }
    }
}

using System;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                StreamReader streamreader = new StreamReader(@"E:\StreamReader\Data1.txt");
                Console.WriteLine(streamreader.ReadToEnd());
                streamreader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Exception();
            ExceptionAbuse();
        }
        public static void Exception()
        {
            try
            {
                Console.WriteLine("Enter Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Denominator");
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int Result = Numerator / Denominator;
                Console.WriteLine($"Result = {Result}");
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be Zero");
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        public static void ExceptionAbuse() //We can implement above code without using exceptions.
        {
            try
            {
                Console.WriteLine("Please enter a number");
                int Numerator;
                bool NumeratorConvertionSucessful = Int32.TryParse(Console.ReadLine(), out Numerator);

                if(NumeratorConvertionSucessful)
                {
                    Console.WriteLine("Please enter a number");
                    int Denominator;
                    bool DenominatorConvertionSucessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                    if (DenominatorConvertionSucessful && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine($"Result = {Result}");
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero.");
                        }
                        else
                        {
                            Console.WriteLine($"Denominator should be a valid number between {Int32.MinValue}, {Int32.MinValue}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Numerator should be a valid number between {Int32.MinValue}, {Int32.MinValue}");
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
}

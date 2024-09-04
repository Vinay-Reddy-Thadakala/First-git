using System;

namespace Methods
{
    class Functions
    {
        public static void Main(string[] args)
        {
            Functions.StaticMethod();
            Functions F = new Functions();
            F.InstanceMethod();
            ParameterOne.ValuePrarameter();
            ParameterTwo.ReferenceParameter();
            ParameterThree.OutParameter();
            ParameterFour.ArrayParameter();
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }
        public void InstanceMethod()
        {
            Console.WriteLine("Instance Method");
        }
    }
    class ParameterOne
    {
        public static void ValuePrarameter()
        {
            int i = 0;
            Demo(i);
            Console.WriteLine("Using Value Parameter i = {0}", i);
        }
        public static void Demo(int j)
        {
            j = 100;
            Console.WriteLine("Using Value Parameter j = {0}", j);

        }
    }
    class ParameterTwo
    {
        public static void ReferenceParameter()
        {
            int i = 0;
            Demo(ref i);
            Console.WriteLine("Using Reference Parameter i = {0}", i);
        }
        public static void Demo(ref int j)
        {
            j = 100;
            Console.WriteLine("Using Reference Parameter j = {0}", j);

        }
    }

    class ParameterThree
    {
        public static void OutParameter()
        {
            int result;
            bool isSuccess = TryDivide(10, 2, out result);

            if (isSuccess)
            {
                Console.WriteLine("Division successful. Result: " + result);
            }
            else
            {
                Console.WriteLine("Division failed.");
            }
        }

        static bool TryDivide(int dividend, int divisor, out int quotient)
        {
            if (divisor == 0)
            {
                quotient = 0; // Must assign a value to the out parameter
                return false; // Indicate failure
            }
            quotient = dividend / divisor;
            return true; // Indicate success
        }
    }

    class ParameterFour
    {
        public static void ArrayParameter()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;
            Demo(Numbers);

        }
        public static void Demo(params int[] Numbers)
        {
            Console.WriteLine("There are {0} Elements in this Array", Numbers.Length);
           
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}


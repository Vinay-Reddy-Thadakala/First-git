using System;

namespace Delegates
{
    public delegate void DelegateFunction(string Str);
    class Program
    {
        static void Main(string[] args)
        {
            DelegateFunction Del = new DelegateFunction(Function);
            Del("Delegates");

            ////Multicast Delegates Example.
            //SampleDelegates Del = new SampleDelegates(SampleMethodOne);
            //Del += SampleMethodTwo;
            //Del += SampleMethodThree;

        }
        public static void Function(string Str)
        {
            Console.WriteLine(Str);
        }
    }
}

//namespace MulticastDelegates
//{

//    public class SampleMulticasstDelegates
//    {
//        public delegate void SampleDelegates();
//        public static void SampleMethodOne()
//        {
//            Console.WriteLine("Sample Method One");
//        }
//        public static void SampleMethodTwo()
//        {
//            Console.WriteLine("Sample Method Two");
//        }
//        public static void SampleMethodThree()
//        {
//            Console.WriteLine("Sample Method Three");
//        }
//    }
//}

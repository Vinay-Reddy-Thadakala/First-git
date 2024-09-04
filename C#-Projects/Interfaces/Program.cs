using System;

namespace Interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            Class C = new Class();
            C.Method1();
            C.Method2();

            IInterface1 I1 = new Class();
            I1.Method1();

            IIneterface2 I2 = new Class();
            I2.Method2();

            //Explicit Interface Implementation.
            IInterfaceOne One = new Explicit(); // It can also done with Type Casting.
            One.Method();

            IInterfaceTwo Two = new Explicit();
            Two.Method();

            //Default Interface Implementation.
            Default D = new Default();
            D.DefaultMethod();
            //Remainging methods should be called Explicitly.
            ((IDefault2)D).DefaultMethod();
        }
    }
    interface IInterface1 // This is Interface One.
    {
        void Method1();
    }
    interface IIneterface2 // This is Interface Two.
    {
        void Method2();
    }
    class Class : IInterface1, IIneterface2 // Class Inherits from Interface-One and Interface-Two.
    {
        public void Method1()
        {
            Console.WriteLine("Implementation of Interface1");
        }
        public void Method2()
        {
            Console.WriteLine("Implementation of Interface2");
        }
    }

    //Explicit Interface Implementation.
    interface IInterfaceOne
    {
        void Method();
    }
    interface IInterfaceTwo 
    {
        void Method();
    }
    class Explicit : IInterfaceOne, IInterfaceTwo
    {
        void IInterfaceOne.Method()
        {
            Console.WriteLine("Explicit Interface Implementation for Interface One.");
        }
        void IInterfaceTwo.Method()
        {
            Console.WriteLine("Explicit Interface Implementation for Interface Two.");
        }
    }

    //Default Interface Implementation.
    interface IDefault1
    {
        void DefaultMethod();
    }
    interface IDefault2
    {
        void DefaultMethod();
    }
    class Default : IDefault1, IDefault2
    {
        public void DefaultMethod()
        {
            Console.WriteLine("Default Implementation");
        }
        void IDefault2.DefaultMethod()
        {
            Console.WriteLine("Explicit Interface Implementation using Type Casting");
        }
    }

}

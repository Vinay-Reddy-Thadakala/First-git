using Execution;
using System;


namespace Inheritance
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Adress;
        public string Email;
        
        public void Details()
        {
            Console.WriteLine("Full Name: ", FirstName, LastName);
            Console.WriteLine("Age: ", Age);
            Console.WriteLine("Adress: ", Adress);
            Console.WriteLine("Email: ", Email);

        }
    }
    public class Fresher : Employee
    {
        public float FreherSalary;
    }

    public class Experienced : Employee 
    {
        public float ExperiencedSalary;
    }


    class Program
    {
        static void Main()
        {
            Fresher F = new Fresher();
            F.FirstName = "Ramesh";
            F.LastName = "Rao";
            F.Age = 24;
            F.Adress = "Karimnagar";
            F.Email = "rameshrao@gmail.com";
            F.FreherSalary = 3.5f;
            F.Details();

            Experienced E = new Experienced();
            E.FirstName = "Suresh";
            E.LastName = "Reddy";
            E.Age = 30;
            E.Adress = "Siddipet";
            E.Email = "sureshreddy@gmail.com";
            E.ExperiencedSalary = 7.5f;
            E.Details();

            // Parent Class Constructer Executes before the Child Class Constructor.  
            FirstChild First = new FirstChild();
            SecondChild Second = new SecondChild();

            //Multiple Clas Inheritance using Intefaces.
            AB ab = new AB();
            ab.MethodA();
            ab.MethodB();
        }
    }
}

namespace Execution // Parent Class Constructer Executes before the Child Class Constructor.
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("This is Parent Class");
        }
    }
    public class FirstChild : Parent
    {
        public FirstChild()
        {
            Console.WriteLine("This is First Child Class");
        }
    }
    public class SecondChild : Parent
    {
        public SecondChild()
        {
            Console.WriteLine("This is Second Child Class");
        }
    }
}

//Multiple Class Inheritance using Interfaces.
namespace Inheritance
{
    interface IA
    {
        void MethodA();
    }
    class A : IA
    {
        public void MethodA()
        {
            Console.WriteLine("Multiple Class Inheritance using Interfaces-A");
        }
    }

    interface IB
    {
        void MethodB();
    }
    class B : IB
    {
        public void MethodB()
        {
            Console.WriteLine("Multiple Class Inheritance using Interfaces-B");
        }
    }
    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void MethodA()
        {
            a.MethodA();
        }
        public void MethodB()
        {
            b.MethodB();
        }
    }

}


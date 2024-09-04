//Classes in C#.
using System;

namespace Classes
{
    class Customer //Class contains fields, methods, constructors and distructor.
    {
        string _FirstName; //Fields.
        string _LastName; //Fields.

        public Customer(string firstname, string lastname) //Constructer.
        {
            this._FirstName = firstname;
            this._LastName = lastname;
        }
        public void FullName() //Method
        {
            Console.WriteLine("Full Name: {0} {1}", this._FirstName, this._LastName);
        }
        ~Customer() //Distructer.
        {
             //used to clean up code.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C = new Customer("Vinay", "Reddy"); //Instance of Class.
            C.FullName();

            Circle C1 = new Circle(5);
            float Area1 = C1.Area();
            Console.WriteLine(Area1);

            Circle C2 = new Circle(6);
            float Area2 = C2.Area();
            Console.WriteLine(Area2);
        }
    }

    class Circle
    {
        static float _PI;
        int _Radius;

        static Circle()
        {
            Circle._PI = 3.141f;
        }

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        public float Area()
        {
            return _PI * this._Radius * this._Radius;
        }
    }   
}   
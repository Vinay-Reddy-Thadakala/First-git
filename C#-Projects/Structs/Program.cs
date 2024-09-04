using System;

namespace Structs
{
    public struct Customer
    {
        //Private Fields.
        private int _id;
        private string _name;
        //Constructor
        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        //Public Properties.
        public int ID 
        {
            set { this._id = value; }
            get { return this._id; }
        }
        public string NAME 
        {
            set { this._name = value; }
            get { return this._name; }
        }

        //Public Method. 
        public void Print() 
        {
            Console.WriteLine("Customer Id = {0}", this._id);
            Console.WriteLine("Customer Id = {0}", this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Using Constructor.
            Customer C1 = new Customer(454, "John");
            C1.Print();

            //Using Properties.
            Customer C2 = new Customer();
            C2.ID = 544;
            C2.NAME = "Snow";
            C2.Print();

            //Using Object Initializer Syntax.
            Customer C3 = new Customer
            {
               ID = 445, NAME = "Mark"
            };
            C3.Print();
        }

    }
}

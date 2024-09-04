using System;
using System.Configuration;

namespace Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passmarks = 35;

        public int Id //Using Properties.
        {
            set //Write only Property.
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid Student Id");
                }
                this._id = value;
            }

            get //Read only Property.
            {
                return this._id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be Null or Empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;  
            }
        }
        public int PassMarks
        {
            get
            {
                return this._passmarks;
            }
        }
        public int Age //Auto Implemented Properties.
        {
            set;
            get;
        }
        public string Email
        {
            set;
            get;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.Id = 5465;
            S.Name = "Rolex";
            S.Age = 30;
            S.Email = "rolex@gmail.com";

            Console.WriteLine("Student Id: {0}", S.Id);
            Console.WriteLine("Student Name: {0}", S.Name);
            Console.WriteLine("PassMarks: {0}", S.PassMarks);
            Console.WriteLine("Student Age: {0}", S.Age);
            Console.WriteLine("Student Email Id: {0}", S.Email);

        }
    }
}

using System;

namespace Method_Hiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void FullName()
        {
            Console.WriteLine("Employee Class: ",FirstName + " " + LastName);
        }
    }
    public class FirstEmployee : Employee
    {
        public new void FullName()
        {
            Console.WriteLine("First Employee Class: ", FirstName + " " + LastName);
        }
    }
    public class SecondEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            FirstEmployee First = new FirstEmployee();
            First.FirstName = "Ramesh";
            First.LastName = "Rao";
            First.FullName();
        }
    }
}

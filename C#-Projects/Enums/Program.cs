using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Max",
                Gender = Gender.Male
            };
            customers[1] = new Customer
            {
                Name = "Riya",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "John",
                Gender = Gender.Unknown
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name: {0}, Gender: {1}", customer.Name, GetGender(customer.Gender));
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                    case Gender.Unknown:
                    return "Unknown";
                    case Gender.Male:
                    return "Male";
                    case Gender.Female:
                    return "Female";
                    default:
                    return "Invalid";

            };
        }
    }

    public enum Gender 
    {
        Unknown,
        Male,
        Female
    }

    public class Customer 
    {
        public string Name {  get; set; }
        public Gender Gender { get; set; }
    }


}

using System;
using System.Reflection;


namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("Reflection.Program");
            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Name);
            Console.WriteLine(T.Namespace);
            Console.WriteLine();

            Console.WriteLine("Properties in Customer class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " "+property.Name);

            }

            Console.WriteLine();
            Console.WriteLine("Methods in Customer class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);

            }

            Console.WriteLine();
            Console.WriteLine("Constructors in Customer class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);

            }

            //Invoking Customer class(Using Late Binding and Early Binding) 

            //The below code is used for Late Binding
            //Assembly executingAssembly Assembly.GetExecutingAssembly();
            //Type customerType executingAssembly.GetType("Pragim.Customer");
            //object customerInstance Activator.CreateInstance(customerType);
            //MethodInfo getFullNameMethod customerType.GetMethod("GetFullName");
            //string[] parameters new string[2];
            //parameters[0] = "Pragim";
            //parameters[1] = "Technologies";
            //string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            //Console.WriteLine("Full Name = {0}", fullName);

            //The below code is used for Early Binding
            //Customer C = new Customer();
            //string FullName = C.GetFullName("Early", "Binding");
            //Console.WriteLine($"Full Name = {FullName}");
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public Student()
        {
            this.Id = -1;
            this.Name = string.Empty; 
        }
        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }

}


//Access modifiers in c#.
using System;
namespace Acess_Modifires
{
    class MainClass 
    {
        public static void Main(string[] args)
        {
            Demo demo = new Demo();
            Console.WriteLine(demo.string1);//Accessible anywhere, no restrictions.
            //Console.WriteLine(demo.string2);//Accessible only with in the containing class.
            //Console.WriteLine(demo.string3);//Accessible with in the containing types and the types derived form the containg type.
            Console.WriteLine(demo.string4);//Accessible anywhere with in the containing assembly.
            Console.WriteLine(demo.string5);//Accessible anywhere in the contining assembly and from within a derived class in another assembly.

            demo.PublicMethod();      
            //demo.PrivateMethod();    
            //demo.ProtectedMethod();  
            demo.InternalMethod();     
            demo.ProtectedInternalMethod();   
           
        }
    }
    class Demo
    {
        public string string1 = "public field";
        private string string2 = "private field";
        protected string string3 = "protected field";
        internal string string4 = "internal field";
        protected internal string string5 = "protected internal field";

        public void PublicMethod()
        {
            Console.WriteLine("public method");

        }
        private void PrivateMethod()
        {
            Console.WriteLine("private method");

        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("protected method");

        }
        internal void InternalMethod()
        {
            Console.WriteLine("internal method");

        }
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("protected internal method");

        }
    }

}

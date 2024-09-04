using System;

namespace Abstract_Classes
{
    public abstract class Abstract
    {
        public abstract void AbstractMethod();
    }
    class Program : Abstract
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract Class");
        }
        static void Main(string[] args)
        {

            Abstract A = new Program();
            A.AbstractMethod();
        }
    }
}

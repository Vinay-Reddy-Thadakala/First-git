using System;

namespace Set_Get_Methods
{
    public class Student
    {
        private int _id;
        public string _name;
        public int _PassMark;

        public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Invalid Student ID");
            }
            this._id = id;
        }
        public int getId()
        {
            return _id;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.setId(55);
            Console.WriteLine("Student Id: ", S1.getId());
        }
    }
}

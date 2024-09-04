//Arrays in C#.
using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //Initializing and Assigning Array in different lines
            int[] Array = new int[5];
            Array[0] = 1;
            Array[1] = 2;
            Array[2] = 3;
            Array[3] = 4;
            Array[4] = 5;
            foreach (int i in Array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(); 

            //Initializing and Assigning Array in same line
            int[] Array2 = {5, 4, 3, 2, 1};
            foreach (int j in Array2)
            {
                Console.WriteLine(j);
            }
        }
    }
}

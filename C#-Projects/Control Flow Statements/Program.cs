//Control flow statements in C#.
using System;

namespace Control_Flow_Statements
{
    class SelectionStatements
    {
        static void Main(string[] args)
        {
            If();
            IfElse();
            IfElseIf();
            NestedIf();
            Switch();
            IterativeStatements.WhileLoop();
            IterativeStatements.DoWhileLoop();
            IterativeStatements.ForLoop();
            IterativeStatements.ForEachLoop();
            JumpStatements.Break();
            JumpStatements.Continue();
            JumpStatements.Goto();
        }

        static void If()
        {
            string Name = "Vinay";     
            if (Name == "Vinay")
            {
                Console.WriteLine("If");
            }
        }
        static void IfElse()
        {
            string Name = "Vinay";
            if (Name != "Vinay")
            {
                Console.WriteLine(Name);
            }
            else
            {
                Console.WriteLine("If Else");
            }
        }
        static void IfElseIf()
        {
            int Number = 0;
            if (Number == 1)
            {
                Console.WriteLine("If");
            }
            else if (Number == 2)
            {
                Console.WriteLine("Else");
            }
            else if (Number == 3)
            {
                Console.WriteLine("If");
            }
            else
            {
                Console.WriteLine("If Else If");
            }
        }

        static void NestedIf()
        {
            int i = 0;
            if (i == 0)
            {
                if (i < 1)
                {
                    Console.WriteLine("Nested If");
                }
            }
        }
        static void Switch()
        {
            char Letter = 'C';
            switch (Letter)
            {
                case 'C': Console.WriteLine("Switch");
                    break;
                case 'B': Console.WriteLine("Switch1");
                    break;
                case 'A': Console.WriteLine("Switch2");
                    break;
                default: Console.WriteLine("None Matches");
                    break;

            }
        }

    }
    class IterativeStatements
    {
        public static void WhileLoop()
        {
            int i = 0;
            while (i < 2)
            {
                Console.WriteLine("While Loop ");
                i++;
            }
        }
        public static void DoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Do While Loop ");
                i++;
            }
            while (i < 2);
        }

        public static void ForLoop()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("For Loop ");
            }
        }

        public static void ForEachLoop()
        {
            int[] a_array = new int[] { 1, 2 }; 
            foreach (int items in a_array)
            {
                Console.WriteLine("For Each Loop: {0}",items);
            }
        }
    }

    class JumpStatements
    {
        public static void Break()
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    break;
            }
            Console.WriteLine("Break");
        }
        public static void Continue()
        {
            for (int i = 1; i <= 2; i++)
            {
                if (i == 1)  
                    continue;
                Console.WriteLine("Continue");
            }
            
        }
        public static void Goto() 
        {
            int number = 20;
            switch (number)
            {
                case 5: Console.WriteLine("Go");
                    break;
                case 10: Console.WriteLine("To");
                    break;
                case 20: Console.WriteLine("Goto");
                    goto case 5;
                default: Console.WriteLine("No match found");
                    break;
            }
        }
    }
}

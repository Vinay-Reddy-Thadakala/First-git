using System;

namespace Nullable_Types
{
    class Null
    {
        static void Main(string[] args)
        {
            bool? AreYouMale = null;
            if (AreYouMale == true)
            {
                Console.WriteLine("User is Male");
            }
            else if (AreYouMale == false)
            {
                Console.WriteLine("User is Female");
            }
            else
            {
                Console.WriteLine("User Belongs to Other Gender");
            }
            NullcoalesingOperator();
        }
        static void NullcoalesingOperator()
        {
            //Without Using Null Coalesing Operator
            int AvailableTickets;
            int? TicketsOnSale = null;
            if (TicketsOnSale == null)
                AvailableTickets = 0;
            else
                AvailableTickets = (int)TicketsOnSale;

            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

            //Using Null Coalesing Operator
            AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

        }
    }
}

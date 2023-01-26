using System;

namespace Inheritance
{
    class CustomerHeading
    {

        public string name;

        public static void HeadingCustomer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("     Customer                                      ");
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

    // derived class of Animal 
    class AgentHeading : CustomerHeading
    {

        public static void HeadingAgent()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("     Agent                                         ");
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class VenueHeading : AgentHeading
    {

        public static void HeadingVenue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("     Venue manager                                        ");
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
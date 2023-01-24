using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.App01;
using TicketSystem.App02;
using TicketSystem.App03;

namespace TicketSystem
{
    internal class Program
    {

        public static List<Venue> Venues = new List<Venue>();

        public static List<Purchase> Purchases = new List<Purchase>();

        public static void Main(string[] args)
        {
            //Main header output
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("    BNU  CO554  CO554 OOP 2022 - 2023              ");
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();

            //selecter for different apps
            string[] choices =
            {
                " Customer",
                " Agent",
                " VenueManager",
            };

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Which Application would you like to use ?");
            Console.WriteLine();

            int choice = Helper.SelectChoice(choices);
            switch (choice)
            {
                case 1:
                    Customer App01 = new Customer();
                    App01.Run();
                    break;
                case 2:
                    Agent App02 = new Agent();
                    App02.Run();
                    break;
                case 3:
                    VenueManager App03 = new VenueManager();
                    App03.Run();
                    break;
            }
        }
    }
}

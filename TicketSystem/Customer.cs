using Inheritance;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.App02;

namespace TicketSystem.App01
{
    internal class Customer
    {
        public void Run()
        {
            //selecter for different apps
            string[] choices =
            {
                " BuyTickets",
                " ListAllShows",
                " SeePurchases",
                " Home",
            };

            AgentHeading.HeadingCustomer();


            int choice = Helper.SelectChoice(choices);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n Select a show: ");
                    var inputted = Console.ReadLine();
                    var show = Program.Venues.FirstOrDefault(x => x.Name.Trim().ToLower() == inputted.Trim().ToLower(), null);
                    if (show == null)
                    {
                        Console.WriteLine("No show with that name");
                        Customer App01 = new Customer();
                        App01.Run();
                        return;
                    }
                    BuyTickets(show);
                    Run();
                    break;
                case 2:
                    ListAllShows();
                    Run();
                    break;
                case 3:
                    SeePurchases();
                    Run();
                    break;
                case 4:
                    Home();
                    Run();
                    break;
            }
        }

        private void Home()
        {
            Program.Main(Array.Empty<string>());
        }

        private void SeePurchases()
        {
            Program.Purchases.ForEach(v =>
            {
                Console.WriteLine($"Show Name: {v.Name} Tickets Brought: Childern:{v.ChildernPurchased} Student:{v.StudentPurchased} Adult:{v.AdultPurchased} Sinior:{v.SiniorAdultPurchased}");
            });

        }

        private void ListAllShows()
        {
            Program.Venues.ForEach(v =>
            {
                Console.WriteLine($"Show Name: {v.Name} Date of show: {v.Time} Childern Seats: {v.Childern} Students Seats: {v.Students} Adults Seats: {v.Adults} SeniorAdults Seats: {v.SeniorAdults} ");
            });
        }

        private void BuyTickets(Venue show)
        {
            Console.WriteLine("How many Childern seats would you like to buy: ");
            String BuySeatsChildern = Console.ReadLine();
            int number5 = Int32.Parse(BuySeatsChildern);
            show.Childern = show.Childern - number5;


            Console.WriteLine("How many Students seats would you like to buy: ");
            String BuySeatsStudents = Console.ReadLine();
            int number6 = Int32.Parse(BuySeatsStudents);
            show.Students = show.Students - number6;

            Console.WriteLine("How many Adults seats would you like to buy: ");
            String BuySeatsAdults = Console.ReadLine();
            int number7 = Int32.Parse(BuySeatsAdults);
            show.Adults = show.Adults - number7;

            Console.WriteLine("How many Senior Adults seats would you like to buy: ");
            String BuySeatsSeniorAdults = Console.ReadLine();
            int number8 = Int32.Parse(BuySeatsSeniorAdults);
            show.SeniorAdults = show.SeniorAdults - number8;

            Program.Purchases.Add(new Purchase { Name = show.Name, AdultPurchased = number7, ChildernPurchased = number5, StudentPurchased = number6, SiniorAdultPurchased = number8 });
        }
    }
}

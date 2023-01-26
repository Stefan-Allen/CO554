using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TicketSystem.App02
{
    internal class Agent
    {
        //run
        public void Run()
        {
            List<string> shows;
            //selecter for different apps
            string[] choices =
            {
                " BuySeatForCustomer",
                " SeeUpcomingEvents",
                " Home",
            };

            AgentHeading.HeadingAgent();


            int choice = Helper.SelectChoice(choices);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n Please Enter the name of the show you would like to cancel ");
                    var inputted = Console.ReadLine();
                    var show = Program.Venues.FirstOrDefault(x => x.Name.Trim().ToLower() == inputted.Trim().ToLower(), null);
                    if (show == null)
                    {
                        Console.WriteLine("No show with that name");
                        return;
                    }
                    BuySeatForCustomer(show);
                    Run();
                    break;
                case 2:
                    SeeUpcomingEvents();
                    Run();
                    break;
                case 3:
                    Home();
                    Run();
                    break;
            }
        }

        private void Home()
        {
            Program.Main(Array.Empty<string>());
        }

        private void SeeUpcomingEvents()
        {
            Program.Venues.ForEach(v =>
            {
                Console.WriteLine($"Show Name: {v.Name}, Date of show: {v.Time}, Childern Seats: {v.Childern}, Students Seats: {v.Students}, Adults Seats: {v.Adults}, SeniorAdults Seats: {v.SeniorAdults} ");
            });
        }

        private void BuySeatForCustomer(Venue show)
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
        }
    }
}

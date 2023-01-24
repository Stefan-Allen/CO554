using Org.BouncyCastle.Utilities.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using TicketSystem.App01;
using TicketSystem.App02;
using TicketSystem.App03;

namespace TicketSystem.App03
{
    internal class VenueManager
    {
        //run
        public void Run()
        {
            //selecter for different apps
            string[] choices =
            {
                " Add Show",
                " Cancel Show",
                " Reschedule",
                " Display all shows",
                " Home",
            };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("     VenueManager                                  ");
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;


            int choice = Helper.SelectChoice(choices);
            switch (choice)
            {
                case 1:
                    AddShow();
                    Run();
                    break;
                case 2:
                    CancelShow();
                    Run();
                    break;
                case 3:
                    Reschedule();
                    Run();
                    break;
                case 4:
                    DisplayAllShows();
                    Run();
                    break;
                case 5:
                    Home();
                    Run();
                    break;
            }
        }

        private void Home()
        {
            Program.Main(Array.Empty<string>());
        }

        private void DisplayAllShows()
        {
            Program.Venues.ForEach(v =>
            {
                Console.WriteLine($"Show Name: {v.Name}, Date of show: {v.Time}, Childern Seats: {v.Childern}, Students Seats: {v.Students}, Adults Seats: {v.Adults}, SeniorAdults Seats: {v.SeniorAdults} ");
            });
        }

        private void Reschedule()
        {
            Console.WriteLine("\n Please Enter the name of the show you would like to Reschedule ");
            var inputted = Console.ReadLine();
            var show = Program.Venues.FirstOrDefault(x => x.Name.Trim().ToLower() == inputted.Trim().ToLower(), null);
            if (show == null)
            {
                Console.WriteLine("No show with that name");
                return;
            }
            Program.Venues.Remove(show);

            Console.WriteLine("\n Enter the new date of the show day/month/year: ");
            var Reschedules = Console.ReadLine();
            show.Time = Reschedules.Trim();
            Program.Venues.Add(show);
            Console.WriteLine($"\n Updated show time {show.Name} ");
        }

        private void CancelShow()
        {
            Console.WriteLine("\n Please Enter the name of the show you would like to cancel ");
            var inputted = Console.ReadLine();
            var show = Program.Venues.FirstOrDefault(x => x.Name.Trim().ToLower() == inputted.Trim().ToLower(), null);
            if (show == null)
            {
                Console.WriteLine("No show with that name");
                return;
            }
            Program.Venues.Remove(show);
            Console.WriteLine($" {show.Name} has been removed ");
        }

        private void AddShow()
        {
            Console.WriteLine("\n Please Enter the name of the show you would like to add ");
            String Name = Console.ReadLine();

            Console.WriteLine("\n Enter the date of the show day/month/year: ");
            String Time = Console.ReadLine();

            Console.WriteLine("\n Enter the Number of childern seats: ");
            String Childern = Console.ReadLine();
            int number1 = Int32.Parse(Childern);

            Console.WriteLine("\n Enter the Number of students seats: ");
            String Students = Console.ReadLine();
            int number2 = Int32.Parse(Students);

            Console.WriteLine("\n Enter the Number of adults seats: ");
            String Adults = Console.ReadLine();
            int number3 = Int32.Parse(Adults);

            Console.WriteLine("\n Enter the Number of senior adults seats: ");
            String SeniorAdults = Console.ReadLine();
            int number4 = Int32.Parse(SeniorAdults);

            Program.Venues.Add(new Venue { Name = Name.Trim(), Time = Time.Trim(), Childern = number1, Students = number2, Adults = number3, SeniorAdults = number4 });
        }
    }
}
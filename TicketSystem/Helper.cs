using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    internal class Helper
    {
        internal static void OutputHeading(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n ---------------------------------");
            Console.WriteLine("     by Stefan Allen           ");
            Console.WriteLine(" ---------------------------------" +
                "\n");

            Console.ForegroundColor = ConsoleColor.Green; ;
        }

        internal static int SelectChoice(string[] choices)
        {
            // Display all the choices

            DisplayChoices(choices);

            // Get the user's choice

            int choiceNo = (int)InputNumber("\n Please enter your choice > ",
                                            1, choices.Length);
            return choiceNo;
        }

        private static int InputNumber(string prompt, double min, double max)
        {
            double number = 0;
            bool isValid;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine(" INVALID NUMBER!");
                }

            } while (!isValid);

            return (int)number;
        }

        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.  {choice}");
            }
        }
    }
}

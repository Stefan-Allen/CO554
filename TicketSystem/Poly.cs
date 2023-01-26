using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem;

namespace TicketSystem
{
    public class Headings
        {
            public static void Title()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine(" ================================================= ");
                Console.WriteLine("    BNU  CO554  CO554 OOP 2022 - 2023              ");
                Console.WriteLine(" ================================================= ");
                Console.WriteLine();
            }
        }

        
    
public class Text : Headings  
{
    public static void Title()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Which Application would you like to use ?");
        Console.WriteLine();
    }
}
}

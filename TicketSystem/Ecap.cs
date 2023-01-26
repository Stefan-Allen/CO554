using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class Ecap
    {
        private String LastName;
        private String FirstName;
        private String Text;

        public String MYFirstName
        {

            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }

        }

        public String MYLastName
        {

            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }

        }

        public String MYText
        {

            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }

        }

    }

    class GFG
    {
        public static void Ecap1()
        {
            Ecap obj = new Ecap();

            obj.MYText = "Program Made By:";
            obj.MYFirstName = "Stefan";
            obj.MYLastName = "Allen";

            Console.WriteLine(obj.MYText + " " + obj.MYFirstName + " " + obj.MYLastName + "\n");

        }
    }
}

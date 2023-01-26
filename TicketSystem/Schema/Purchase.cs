using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    internal class Purchase
    {
        public string Name { get; set; }

        public int ChildernPurchased { get; set; }

        public int StudentPurchased { get; set; }

        public int AdultPurchased { get; set; }

        public int SiniorAdultPurchased { get; set; }

        public int Purchased { get; set; }
    }
}

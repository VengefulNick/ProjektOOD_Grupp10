using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Ticket
    {
        private enum TicketStatus
        {
            Confirmed, Pending, Abandoned, Cancelled
        }

        private uint TicketId { get; set; }
        private int NumberOfSeats { get; set; } // Antal biljetter som ska köpas, 1-5.
        private DateTime OrderDate;
        private int price { get; set; }
        private TicketStatus Status { get; set; }
    }
}

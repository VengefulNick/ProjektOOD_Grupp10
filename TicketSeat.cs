using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class TicketSeat
    {
        private int SeatNr { get; set; }
        private bool Reserved { get; set; }

        public int GetSeatNr()
        {
            return SeatNr;
        }

        public bool IsReserved()
        {
            return Reserved;
        }

    }

}

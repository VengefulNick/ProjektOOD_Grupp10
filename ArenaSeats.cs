using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class ArenaSeats : TicketSeat
    {
        enum SeatType
        {
            Bench, FoldingChair
        }

        int[] Seats;

        private SeatType seatType;
        private int RowNr { get; set; }
        private int ColNr { get; set; }
        private int TotalSeats { get; set; }

        public ArenaSeats(int SeatRows, int SeatCols)
        {
            this.RowNr = SeatRows;
            this.ColNr = SeatCols;
            TotalSeats = SeatRows * SeatCols;
        }
        
    }
}

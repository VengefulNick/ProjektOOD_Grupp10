using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Arena
    {
        private string ArenaName { get; set; }
        private int SeatRows { get; set; }
        private int SeatCols { get; set; }

        public Arena(string arenaName, int SeatRows, int SeatCols)
        {
            this.ArenaName = arenaName;
            this.SeatRows = SeatRows;
            this.SeatCols = SeatCols;
        }

        public void CreateSeats(int SeatRows, int SeatCols)
        {
            ArenaSeats arenaSeats = new ArenaSeats(SeatRows, SeatCols);

        }
    }
}

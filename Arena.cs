using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Arena
    {
        public string ArenaName { get; set; }
        public int TotalSeats { get; set; }

        public Arena(string arenaName, int totalSeats)        {
            this.ArenaName = arenaName;
            this.TotalSeats = totalSeats;
        }

    }
}

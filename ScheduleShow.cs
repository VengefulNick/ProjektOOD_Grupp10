using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class ScheduleShow
    {
        private List<object> ScheduledShows = new List<object>();
        private int ScheduleId { get; set; }
        private string StartTime { get; set; }
        private int TotalTickets { get; set; }
        public ScheduleShow(int ScheduleId, string StartTime, int totalTickets)
        {
            this.ScheduleId = ScheduleId;
            this.StartTime = StartTime;
            this.TotalTickets = totalTickets;
        }
    }
}

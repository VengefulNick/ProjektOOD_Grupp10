using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class ScheduleShow
    {
        private int ScheduleId { get; set; }
        private DateTime StartTime { get; set; }

        public ScheduleShow(int ScheduleId, DateTime StartTime)
        {
            this.ScheduleId = ScheduleId;
            this.StartTime = StartTime;
        }
    }
}

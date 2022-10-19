using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Concert
    {
        private int EventId { get; set; }
        private string EventName { get; set; }
        private int EventDuration { get; set; }
        private string ReleaseDate { get; set; }

        public Concert(int id, string name, int duration, string date)
        {
            this.EventId = id;
            this.EventName = name;
            this.EventDuration = duration;
            this.ReleaseDate = date;
        }

        public int GetId()
        {
            return EventId;
        }
        public string GetName()
        {
            return EventName;
        }
        public int GetDuration()
        {
            return EventDuration;
        }
        public string GetRelease()
        {
            return ReleaseDate;
        }
     
    }
}

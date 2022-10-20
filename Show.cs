using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Show
    {
        List<string> ShowList = new List<string>();
        private int ShowId { get; set; }
        private string ShowName { get; set; }
        private int ShowDuration { get; set; }
        private string ReleaseDate { get; set; }

        public Show(int id, string name, int duration, string date)
        {
            this.ShowId = id;
            this.ShowName = name;
            this.ShowDuration = duration;
            this.ReleaseDate = date;
        }

        public int GetId()
        {
            return ShowId;
        }
        public string GetName()
        {
            return ShowName;
        }
        public int GetDuration()
        {
            return ShowDuration;
        }
        public string GetRelease()
        {
            return ReleaseDate;
        }
     

    }
}

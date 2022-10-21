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

        private string ShowName { get; set; }
        private int ShowDuration { get; set; }
        private string ReleaseDate { get; set; }

        public Show(string name, int duration, string date)
        {
            this.ShowName = name;
            this.ShowDuration = duration;
            this.ReleaseDate = date;
        }

        public string GetName()
        {
            return this.ShowName;
        }

        public int GetDuration()
        {
            return this.ShowDuration;
        }
        public string GetRelease()
        {
            return this.ReleaseDate;
        }

    }
}

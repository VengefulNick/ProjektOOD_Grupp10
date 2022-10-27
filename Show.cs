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
        private string ReleaseDate { get; set; }

        public Show(string name, string date)
        {
            this.ShowName = name;
            this.ReleaseDate = date;
        }

        public string GetName()
        {
            return this.ShowName;
        }
        public string GetRelease()
        {
            return this.ReleaseDate;
        }

    }
}

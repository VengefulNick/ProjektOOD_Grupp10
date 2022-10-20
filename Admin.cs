using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Admin : Person
    {
        // Constructor
        public Admin(int id, string name, string email, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public void AddShow()
        {
           
        }

        public void AddShowSchedule()
        {

        }

        public void ModifyShow()
        {
            //Modify code goes here !!!NOT IMPLEMENTED FOR DEMO!!!
        }
    }
}

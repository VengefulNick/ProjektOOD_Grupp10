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
        //List<object> ShowList = new List<object>();

        public Admin(string name, string email, string phone)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public void AddShow()
        {
            // Code to add new show to showList
            Console.WriteLine("Enter show name: ");
            string name = Console.ReadLine();
            Console.WriteLine(" Enter duration for show: ");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter date for ticket release (YYYY:MM:DD hh:mm): ");
            string release = Console.ReadLine();
            Console.WriteLine("");

            Show show = new Show(name, duration, release);

            ShowLibrary.ListShow(show);
            ShowLibrary.QueueShow(show);
        }


        public void AddShowSchedule()
        {
            // Code to add a schedule for a show from the showlist
        }

        public void ModifyShow()
        {
            // Code to modify an already implemented show. ex. duration or date etc.
        }
        public void CancelShow()
        {
            // Code to remove show from ShowList or ShowQueue
        }
    }
}

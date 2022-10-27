using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    // EXAMPLE OF INHERITANCE
    internal class Admin : Person
    {
        static int IdCounter = 0;
        public Admin(string Name)
        {
            IdCounter += 1;
            Id = IdCounter;
            this.Name = Name;
        }

            // WHOAMI
        public void GetAdminInfo() 
        {
            Console.WriteLine($"Id: {this.Id} | Name: {this.Name}");
        }

            // CRUD - CREATE
        public void AddShow()
        {
            Console.WriteLine("# ADD STARTED #");
            // Code to add new show to showList

                // Add 10 Demo Shows
            for (int i = 1; i < 11; i++)
            {
                Show DemoShow = new Show("Number: " + i.ToString(), "2022-12-24");
                ShowLibrary.ListShow(DemoShow);
                ShowLibrary.QueueShow(DemoShow);
            }
            Console.WriteLine("# ADD COMPLETED #");
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

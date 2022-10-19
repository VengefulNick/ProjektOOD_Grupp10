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
        int Counter = 1;

        // Constructor
        public Admin(int id, string name, string email, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public void AddConcert()
        {
            int Id = Counter++;
            string name = Convert.ToString(Id);

            Console.WriteLine("Enter name of Concert: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter duration in minutes: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            string date = DateTime.Now.ToString("yyyy/MM/dd");

            Concert concert = new Concert(Id, name, duration, date);

            Console.WriteLine($"Success creating Consert Id: {concert.GetId()} | NAME: {concert.GetName()} | Duration: {concert.GetDuration()} minutes | Release date: {concert.GetRelease()}");
        }

        public void AddEventSchedule()
        {

        }

        public void ModifyEvent()
        {
            //Modify event code goes here !!!NOT IMPLEMENTED FOR DEMO!!!
        }
    }
}

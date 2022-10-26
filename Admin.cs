﻿using System;
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
        public Admin(int id, string name, string email, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public void GetAdminInfo()
        {
            Console.WriteLine($"Id: {this.Id} | Name: {this.Name} | Email: {this.Email} | Phone: {this.Phone}");
        }

        public void AddShow()
        {
            Console.WriteLine("# ADD STARTED #");
            // Code to add new show to showList
            /*
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
            */

                // Add 10 Demo Shows
            for (int i = 1; i < 11; i++)
            {
                Show DemoShow = new Show("Number: " + i.ToString(), 60, "2022-12-24");
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

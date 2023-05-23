using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    // EXAMPLE OF INHERITANCE
    internal class Customer : Person
    {
        static int IdCounter = 0;
        public Customer(string Name)
        {
            IdCounter += 1;
            Id = IdCounter;
            this.Name = Name;
        }

        // WHOAMI - EXAMPLE OF POLYMORPHISM
        public new void GetInfo()
        {
            Console.WriteLine("Customer info: ");
            Console.WriteLine($"Id: {this.Id} | Name: {this.Name}");
        }

        // CRUD - READ
        public void ViewAvailableShows()
        {
            Console.WriteLine("Current available shows: ");
            ShowLibrary.DisplayShowList();
            Console.WriteLine("");

            Console.WriteLine("Current available queue: ");
            ShowLibrary.DisplayShowQueue();
            Console.WriteLine("");
        }
        public void BuyTicket()
        {
            // Code to Buy ticket
            // Tidsgräns på 10minuter att köpa
        }
        public void CancelTicket()
        {
            //Code to Cancel Ticket
        }

    }
}

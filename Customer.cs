using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Customer : Person
    {
        static int IdCounter = 0;
        public Customer(string Name)
        {
            IdCounter += 1;
            Id = IdCounter;
            this.Name = Name;
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
            // WHOAMI
        public void GetCustomerInfo()
        {
            Console.WriteLine($"Id: {this.Id} | Name: {this.Name}");
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

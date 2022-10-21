using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Customer : Person
    {
        public Customer(string name, string email, string phone)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }
        public void ViewAvailibleShows()
        {
            Console.WriteLine("Current available shows: ");
            ShowLibrary.DisplayShowList();
        }

        public void BuyTicket()
        {
            // Recursive / Loop Code to buy tickets for a show
        }

        public void CancelTicket()
        {
            //Code to Cancel Ticket
        }
    }
}

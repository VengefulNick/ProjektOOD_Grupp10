using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Customer : Person
    {
        public Customer(int id, string name, string email, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public void GetCustomerInfo()
        {
            Console.WriteLine($"Id: {this.Id} | Name: {this.Name} | Email: {this.Email} | Phone: {this.Phone}");
        }

        public void ViewAvailableShows() {}

        public void BuyTicket()
        {
            Console.WriteLine("What show do you wanna book tickets for?: ");
            int show = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select amount of tickets you would like to buy(1-5): ");
            int amount = Convert.ToInt32(Console.ReadLine());
        }

        public void CancelTicket()
        {
            //Code to Cancel Ticket
        }
    }
}

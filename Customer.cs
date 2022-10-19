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

        public void BuyTicket()
        {
            Ticket ticket = new Ticket();
        }

        public void ViewTicket()
        {

        }
    }
}

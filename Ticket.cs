using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOD_Grupp10
{
    internal class Ticket
    {
        private int TicketId { get; set; }
        private string OrderDate { get; set; }
        private int Price { get; set; }

        public Ticket(int TicketId, int AmountOfTickets)
        {
            this.TicketId = TicketId;
            OrderDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            this.Price = 100;
        }

        public int GetTicketId()
        {
            return this.TicketId;
        }
        public string GetOrderDate()
        {
            return this.OrderDate;
        }
        public int GetPrice()
        {
            return this.Price;
        }
    }
}

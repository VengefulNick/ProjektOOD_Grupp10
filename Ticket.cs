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
        private List<object> TicketList = new List<object>();

        private Queue<object> OrderQueue = new Queue<object>();

        private int TicketId { get; set; }
        private string OrderDate { get; set; }
        private int Price { get; set; }

        // Methods
        public void CreateTicket(int id, int amountoftickets)
        {
            // Recursive creation of amount of tickets
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

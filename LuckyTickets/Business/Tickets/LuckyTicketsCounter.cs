using System.Collections.Generic;
using System.Linq;
using LuckyTickets.Business.Models;
using LuckyTickets.Tickets.Interfaces;

namespace LuckyTickets.Business.Tickets
{
    public class LuckyTicketsCounter
    {
        private readonly ILuckyTicketResolver luckyTicketResolver;

        public LuckyTicketsCounter(ILuckyTicketResolver luckyTicketResolver)
        {
            this.luckyTicketResolver = luckyTicketResolver;
        }

        public int Count(IEnumerable<Ticket> tickets)
        {
            return tickets.Count(t => luckyTicketResolver.IsLucky(t));
        }
    }
}
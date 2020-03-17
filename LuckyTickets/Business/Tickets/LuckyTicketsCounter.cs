using System.Collections.Generic;
using System.Linq;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;

namespace LuckyTickets.Business.Tickets
{
    public class LuckyTicketsCounter
    {
        #region Private Members

        private readonly ILuckyTicketResolver luckyTicketResolver;

        #endregion

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
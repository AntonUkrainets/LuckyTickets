using System.Collections.Generic;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Providers.Interfaces;

namespace LuckyTickets.Business.Tickets.Providers
{
    public class TicketsGenerator : ITicketsProvider
    {
        #region Private Members

        private readonly int startIndex;
        private readonly int endIndex;

        #endregion

        public TicketsGenerator(int startIndex, int endIndex)
        {
            this.startIndex = startIndex;
            this.endIndex = endIndex;
        }

        public IEnumerable<Ticket> GetTickets()
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                yield return new Ticket(i);
            }
        }
    }
}
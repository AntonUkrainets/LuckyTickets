using System.Collections.Generic;
using LuckyTickets.Business.Models;

namespace LuckyTickets.Business.Tickets.Providers.Interfaces
{
    public interface ITicketsProvider
    {
        IEnumerable<Ticket> GetTickets();
    }
}
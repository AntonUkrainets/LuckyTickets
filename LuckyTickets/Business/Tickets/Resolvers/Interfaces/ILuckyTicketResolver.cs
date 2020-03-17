using LuckyTickets.Business.Models;

namespace LuckyTickets.Business.Tickets.Resolvers.Interfaces
{
    public interface ILuckyTicketResolver
    {
        string Name { get; }
        bool IsLucky(Ticket ticket);
    }
}
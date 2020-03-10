using LuckyTickets.Business.Models;

namespace LuckyTickets.Tickets.Interfaces
{
    public interface ILuckyTicketResolver
    {
        string Name { get; }
        bool IsLucky(Ticket ticket);
    }
}
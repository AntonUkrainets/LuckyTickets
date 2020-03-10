using LuckyTickets.Tickets.Interfaces;

namespace LuckyTickets.Tickets.Resolvers.Interfaces
{
    public interface ILuckyTicketResolverFactory
    {
        ILuckyTicketResolver Create(string algorithm);
    }
}
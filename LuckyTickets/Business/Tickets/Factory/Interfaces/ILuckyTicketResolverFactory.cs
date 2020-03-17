using LuckyTickets.Business.Tickets.Resolvers.Interfaces;

namespace LuckyTickets.Business.Tickets.Factory.Interfaces
{
    public interface ILuckyTicketResolverFactory
    {
        ILuckyTicketResolver Create(string algorithm);
    }
}
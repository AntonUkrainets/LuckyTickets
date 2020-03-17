using LuckyTickets.Business.Tickets.Factory.Interfaces;
using LuckyTickets.Business.Tickets.Resolvers;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;

namespace LuckyTickets.Business.Tickets.Factory
{
    public class LuckyTicketResolverFactory : ILuckyTicketResolverFactory
    {
        public ILuckyTicketResolver Create(string algorithm) 
            => algorithm switch
        {
            "Moskow" => new MoskowLuckyTicketResolver(),
            "Piter" => new PiterLuckyTicketResolver(),
            _ => null
        };
    }
}
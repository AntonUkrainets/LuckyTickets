using LuckyTickets.Tickets.Interfaces;
using LuckyTickets.Tickets.Resolvers.Interfaces;

namespace LuckyTickets.Tickets.Resolvers.Implements
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
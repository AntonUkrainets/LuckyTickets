using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;

namespace LuckyTickets.Business.Tickets.Resolvers
{
    public class MoskowLuckyTicketResolver : ILuckyTicketResolver
    {
        public string Name => "Moskow";

        public bool IsLucky(Ticket ticket)
        {
            var firstPart = GetFirstDigits(ticket.Number);
            var secondPart = GetLastDigits(ticket.Number);

            return firstPart == secondPart;
        }

        private int GetFirstDigits(int number)
        {
            while(number >= 1000)
            {
                number /= 10;
            }

            return number;
        }

        private int GetLastDigits(int number)
        {
            return number % 1000;
        }
    }
}
using LuckyTickets.Business.Models;
using LuckyTickets.Tickets.Interfaces;

namespace LuckyTickets.Tickets.Resolvers.Implements
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
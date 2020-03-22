using System.Linq;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;
using LuckyTickets.Extensions;

namespace LuckyTickets.Business.Tickets.Resolvers
{
    public class MoskowLuckyTicketResolver : ILuckyTicketResolver
    {
        public string Name => "Moskow";

        public bool IsLucky(Ticket ticket)
        {
            var firstPart = GetFirstDigitsSum(ticket.Number);
            var secondPart = GetLastDigitsSum(ticket.Number);

            return firstPart == secondPart;
        }

        private int GetFirstDigitsSum(int number)
        {
            var firstDigits = GetFirstDigits(number);
            var digits = firstDigits.SplitToParts();

            return digits.Sum();
        }

        private int GetLastDigitsSum(int number)
        {
            var lastDigits = GetLastDigits(number);
            var digits = lastDigits.SplitToParts();

            return digits.Sum();
        }

        private int GetFirstDigits(int number)
        {
            return number / 1000;
        }

        private int GetLastDigits(int number)
        {
            return number % 1000;
        }
    }
}
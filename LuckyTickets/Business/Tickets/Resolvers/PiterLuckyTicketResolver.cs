using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;
using LuckyTickets.Extensions;

namespace LuckyTickets.Business.Tickets.Resolvers
{
    public class PiterLuckyTicketResolver : ILuckyTicketResolver
    {
        public string Name => "Piter";

        public bool IsLucky(Ticket ticket)
        {
            var sumEvenNumbers = 0;
            var sumOddNumbers = 0;

            GetSumWholeNumbers(
                ref sumEvenNumbers,
                ref sumOddNumbers,
                ticket.Number
            );

            return sumEvenNumbers == sumOddNumbers;
        }

        private void GetSumWholeNumbers(
            ref int sumEvenNumbers,
            ref int sumOddNumbers,
            int number
        )
        {
            var numbers = number.SplitToParts();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                    sumEvenNumbers += item;
                else
                    sumOddNumbers += item;
            }
        }
    }
}
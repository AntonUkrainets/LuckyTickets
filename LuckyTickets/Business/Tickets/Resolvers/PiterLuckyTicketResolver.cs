using System.Collections.Generic;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;

namespace LuckyTickets.Business.Tickets.Resolvers
{
    public class PiterLuckyTicketResolver : ILuckyTicketResolver
    {
        public string Name => "Piter";

        public bool IsLucky(Ticket ticket)
        {
            var sumEvenNumbers = 0;
            var sumOddNumbers = 0;

            GetSumWholeNumbers(ref sumEvenNumbers, ref sumOddNumbers, ticket.Number);

            return sumEvenNumbers == sumOddNumbers;
        }

        private void GetSumWholeNumbers(
            ref int sumEvenNumbers,
            ref int sumOddNumbers,
            int number
        )
        {
            var numbers = SplitToParts(number);

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                    sumEvenNumbers += item;
                else
                    sumOddNumbers += item;
            }
        }

        private IEnumerable<int> SplitToParts(int numbers)
        {
            var digits = new List<int>();

            while (numbers != 0)
            {
                var value = numbers % 10;
                digits.Add(value);

                numbers /= 10;
            }

            return digits;
        }
    }
}
using LuckyTickets.Business.Models;
using LuckyTickets.Tickets.Interfaces;
using System.Collections.Generic;

namespace LuckyTickets.Tickets.Resolvers.Implements
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
            var numbers = ConvertToArray(number);

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                    sumEvenNumbers += item;
                else
                    sumOddNumbers += item;
            }
        }

        private IEnumerable<int> ConvertToArray(int numbers)
        {
            var digits = new List<int>();

            while (numbers != 0)
            {
                var value = numbers % 10;
                digits.Insert(0, value);

                numbers /= 10;
            }

            return digits;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Providers;
using LuckyTicketsTests.Comparer;
using Xunit;

namespace LuckyTicketsTests.Business.Tickets.Providers
{
    public class TicketsGeneratorTests
    {
        [Theory]
        [InlineData(1, 3)]
        public void GetTickets(int startIndex, int endIndex)
        {
            // Arrange
            var ticketsGenerator = new TicketsGenerator(startIndex, endIndex);

            IEnumerable<Ticket> expectedTickets = new List<Ticket>
            {
                new Ticket(1),
                new Ticket(2),
                new Ticket(3)
            };

            // Act
            var actualTickets = ticketsGenerator.GetTickets();

            var luckyTicketComparer = new LuckyTicketEqualityComparer();

            // Assert
            Assert.Equal(expectedTickets, actualTickets, luckyTicketComparer);
        }
    }
}
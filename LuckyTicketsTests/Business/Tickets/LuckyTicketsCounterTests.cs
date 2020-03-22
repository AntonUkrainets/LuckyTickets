using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets;
using LuckyTickets.Business.Tickets.Factory.Interfaces;
using LuckyTickets.Business.Tickets.Resolvers;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;
using Moq;
using Xunit;

namespace LuckyTicketsTests.Business.Tickets
{
    public class LuckyTicketsCounterTests
    {
        [Fact]
        public void Count()
        {
            // Arrange
            var mockLuckyTicketsCounter = new Mock<ILuckyTicketResolver>();
            mockLuckyTicketsCounter
                .Setup(x => x.IsLucky(It.IsAny<Ticket>()))
                .Returns(true);

            var luckyTicketsCounter = new LuckyTicketsCounter(mockLuckyTicketsCounter.Object);

            var tickets = new Ticket[]
            {
                new Ticket(121121),
                new Ticket(427931),
                new Ticket(101011)
            };

            // Act
            var count = luckyTicketsCounter.Count(tickets);

            // Assert
            mockLuckyTicketsCounter.Verify(
                x => x.IsLucky(It.IsAny<Ticket>()),
                Times.Exactly(3)
            );

            Assert.Equal(tickets.Count(), count);
        }
    }
}
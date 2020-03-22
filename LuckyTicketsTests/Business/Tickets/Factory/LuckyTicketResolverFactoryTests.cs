using System;
using System.Collections.Generic;
using System.Text;
using LuckyTickets.Business.Tickets.Factory;
using LuckyTickets.Business.Tickets.Resolvers;
using Xunit;

namespace LuckyTicketsTests.Business.Tickets.Factory
{
    public class LuckyTicketResolverFactoryTests
    {
        [Fact]
        public void CreateMoskowLuckyTicket()
        {
            // Arrange
            var algorithm = "Moskow";
            var luckyTicketResolverFactory = new LuckyTicketResolverFactory();

            // Act
            var luckyTicketResolver = luckyTicketResolverFactory.Create(algorithm);

            // Assert
            Assert.IsType<MoskowLuckyTicketResolver>(luckyTicketResolver);
        }

        [Fact]
        public void CreatePiterLuckyTicket()
        {
            // Arrange
            var algorithm = "Piter";
            var luckyTicketResolverFactory = new LuckyTicketResolverFactory();

            // Act
            var luckyTicketResolver = luckyTicketResolverFactory.Create(algorithm);

            // Assert
            Assert.IsType<PiterLuckyTicketResolver>(luckyTicketResolver);
        }
    }
}
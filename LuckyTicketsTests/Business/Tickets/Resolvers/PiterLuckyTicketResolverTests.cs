using System;
using System.Collections.Generic;
using System.Text;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Resolvers;
using Xunit;

namespace LuckyTicketsTests.Business.Tickets.Resolvers
{
    public class PiterLuckyTicketResolverTests
    {
        #region Private Members

        private readonly PiterLuckyTicketResolver piterLuckyTicketResolver;

        #endregion

        public PiterLuckyTicketResolverTests()
        {
            piterLuckyTicketResolver = new PiterLuckyTicketResolver();
        }

        [Theory]
        [InlineData(121)]
        [InlineData(2123)]
        [InlineData(4556)]
        public void IsLucky_Positive(int number)
        {
            // Arrange
            var ticket = new Ticket(number);

            // Act
            var actualValue = piterLuckyTicketResolver.IsLucky(ticket);

            // Assert
            Assert.True(actualValue);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(111)]
        [InlineData(789)]
        public void IsLucky_Negative(int number)
        {
            // Arrange
            var ticket = new Ticket(number);

            // Act
            var actualValue = piterLuckyTicketResolver.IsLucky(ticket);

            // Assert
            Assert.False(actualValue);
        }
    }
}
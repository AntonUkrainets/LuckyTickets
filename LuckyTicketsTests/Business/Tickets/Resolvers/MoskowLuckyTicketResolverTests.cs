using System;
using System.Collections.Generic;
using System.Text;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Resolvers;
using Xunit;

namespace LuckyTicketsTests.Business.Tickets.Resolvers
{
    public class MoskowLuckyTicketResolverTests
    {
        #region Private Members

        private readonly MoskowLuckyTicketResolver moskowLuckyTicketResolver;

        #endregion

        public MoskowLuckyTicketResolverTests()
        {
            moskowLuckyTicketResolver = new MoskowLuckyTicketResolver();
        }

        [Theory]
        [InlineData(121121)]
        [InlineData(427931)]
        [InlineData(101011)]
        [InlineData(011011)]
        public void IsLucky_Positive(int number)
        {
            // Arrange
            var ticket = new Ticket(number);

            // Act
            var actualValue = moskowLuckyTicketResolver.IsLucky(ticket);

            // Assert
            Assert.True(actualValue);
        }

        [Theory]
        [InlineData(123456)]
        [InlineData(456789)]
        [InlineData(789011)]
        public void IsLucky_Negative(int number)
        {
            // Arrange
            var ticket = new Ticket(number);

            // Act
            var actualValue = moskowLuckyTicketResolver.IsLucky(ticket);

            // Assert
            Assert.False(actualValue);
        }
    }
}
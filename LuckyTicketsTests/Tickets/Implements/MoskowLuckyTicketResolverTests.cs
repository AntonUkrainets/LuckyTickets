using LuckyTickets;
using LuckyTickets.Business.Models;
using LuckyTickets.Tickets.Resolvers.Implements;
using Xunit;

namespace LuckyTicketsTests.Tickets.Implements
{
    public class MoskowLuckyTicketResolverTests
    {
        [Theory]
        [InlineData(011011, true)]
        [InlineData(111111, true)]
        [InlineData(111112, false)]
        public void IsLucky(int number, bool expectedIsLucky)
        {
            // Arrange
            var ticket = new Ticket(number);
            var resolver = new MoskowLuckyTicketResolver();

            // Act
            var actualIsLucky = resolver.IsLucky(ticket);

            // Assert
            Assert.Equal(expectedIsLucky, actualIsLucky);
        }
    }
}
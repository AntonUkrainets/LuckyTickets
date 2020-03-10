using LuckyTickets;
using LuckyTickets.Tickets.Implements;
using Xunit;

namespace LuckyTicketsTests.Tickets.Implements
{
    public class PiterLuckyTicketResolverTests
    {
        [Theory]
        [InlineData(102001, true)]
        [InlineData(121121, true)]
        [InlineData(111112, false)]
        public void IsLucky(int number, bool expectedIsLucky)
        {
            // Arrange
            var ticket = new Ticket(number);
            var resolver = new PiterLuckyTicketResolver();

            // Act
            var actualIsLucky = resolver.IsLucky(ticket);

            // Assert
            Assert.Equal(expectedIsLucky, actualIsLucky);
        }
    }
}

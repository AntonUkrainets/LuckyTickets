using System;
using System.Collections.Generic;
using System.Text;
using Liba.Logger.Interfaces;
using LuckyTickets.Business.Tickets;
using LuckyTickets.Business.Tickets.Factory;
using LuckyTickets.Business.Tickets.Factory.Interfaces;
using LuckyTickets.Business.Tickets.Resolvers;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;
using LuckyTickets.Core;
using Moq;
using Xunit;

namespace LuckyTicketsTests.Business.Tickets
{
    public class LuckyTicketProcessorTests
    {
        #region Private Members

        private readonly Mock<ILogger> mockLogger;

        #endregion

        public LuckyTicketProcessorTests()
        {
            mockLogger = new Mock<ILogger>();
        }

        [Fact]
        public void Process_PiterAlgorithm()
        {
            // Arrange
            var ticketsTask = new TicketsTask
            {
                Algorithm = "Piter"
            };

            var expectedMessage = "You have 25081 lucky tickets";

            var mockLuckyTicketResolverFactory = new Mock<ILuckyTicketResolverFactory>();
            mockLuckyTicketResolverFactory
                    .Setup(f => f.Create(ticketsTask.Algorithm))
                    .Returns(new PiterLuckyTicketResolver());

            // Act
            var actualMessage = string.Empty;

            mockLogger.Setup(l => l.LogInformation(It.IsAny<string>()))
                      .Callback<string>(message => actualMessage = message);

            var luckyTicketProcessor = new LuckyTicketProcessor(mockLogger.Object, mockLuckyTicketResolverFactory.Object);
            luckyTicketProcessor.Process(ticketsTask);

            // Assert
            Assert.Equal(expectedMessage, actualMessage);
        }

        [Fact]
        public void Process_MoskowAlgorithm()
        {
            // Arrange
            var ticketsTask = new TicketsTask
            {
                Algorithm = "Moskow"
            };

            var expectedMessage = "You have 55252 lucky tickets";

            var mockLuckyTicketResolverFactory = new Mock<ILuckyTicketResolverFactory>();
            mockLuckyTicketResolverFactory
                    .Setup(f => f.Create(ticketsTask.Algorithm))
                    .Returns(new MoskowLuckyTicketResolver());

            var actualMessage = string.Empty;

            mockLogger.Setup(l => l.LogInformation(It.IsAny<string>()))
                      .Callback<string>(message => actualMessage = message);

            var luckyTicketProcessor = new LuckyTicketProcessor(mockLogger.Object, mockLuckyTicketResolverFactory.Object);
            
            // Act
            luckyTicketProcessor.Process(ticketsTask);

            // Assert
            Assert.Equal(expectedMessage, actualMessage);
        }
    }
}
using System.Collections.Generic;
using Liba.Logger.Interfaces;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Factory.Interfaces;
using LuckyTickets.Business.Tickets.Providers;
using LuckyTickets.Business.Tickets.Providers.Interfaces;
using LuckyTickets.Business.Tickets.Resolvers.Interfaces;
using LuckyTickets.Core;

namespace LuckyTickets.Business.Tickets
{
    public class LuckyTicketProcessor
    {
        #region Private Members

        private readonly ILogger logger;
        private readonly ILuckyTicketResolverFactory luckyTicketResolverFactory;

        #endregion

        public LuckyTicketProcessor(
            ILogger logger,
            ILuckyTicketResolverFactory luckyTicketResolverFactory
        )
        {
            this.logger = logger;
            this.luckyTicketResolverFactory = luckyTicketResolverFactory;
        }

        public void Process(TicketsTask inputData)
        {
            string algorithm = inputData.Algorithm;

            ITicketsProvider ticketsProvider = new TicketsGenerator(
                startIndex: 0,
                endIndex: 999999
            );

            IEnumerable<Ticket> tickets = ticketsProvider.GetTickets();

            ILuckyTicketResolver luckyTicketResolver = luckyTicketResolverFactory.Create(algorithm);

            var counter = new LuckyTicketsCounter(luckyTicketResolver);

            var luckyTicketsNumber = counter.Count(tickets);

            logger.LogInformation($"You have {luckyTicketsNumber} lucky tickets");
        }
    }
}
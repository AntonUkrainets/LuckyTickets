using System.Collections.Generic;
using Liba.Logger.Interfaces;
using LuckyTickets.Business.Models;
using LuckyTickets.Business.Tickets.Providers.Implements;
using LuckyTickets.Business.Tickets.Providers.Interfaces;
using LuckyTickets.Model;
using LuckyTickets.Tickets.Interfaces;
using LuckyTickets.Tickets.Resolvers.Interfaces;

namespace LuckyTickets.Business.Tickets
{
    public class LuckyTicketProcessor
    {
        private readonly ILogger logger;
        private readonly ILuckyTicketResolverFactory luckyTicketResolverFactory;

        public LuckyTicketProcessor(
            ILogger logger,
            ILuckyTicketResolverFactory luckyTicketResolverFactory
        )
        {
            this.logger = logger;
            this.luckyTicketResolverFactory = luckyTicketResolverFactory;
        }

        public void Process(InputData inputData)
        {
            string algorithm = inputData.Algorithm;

            ITicketsProvider ticketsProvider = new TicketsGenerator(
                startIndex: 100000,
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
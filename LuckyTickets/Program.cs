using Liba.Logger;
using Liba.Logger.Interfaces;
using LuckyTickets.Business.Tickets;
using LuckyTickets.Business.Tickets.Factory;
using LuckyTickets.Business.Tickets.Factory.Interfaces;
using LuckyTickets.Core;

namespace LuckyTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logPath = "application.log";

            ILogger logger = new AggregatedLogger(
                new ConsoleLogger(),
                new FileLogger(logPath)
            );

            ILuckyTicketResolverFactory luckyTicketResolverFactory =
                new LuckyTicketResolverFactory();

            var luckyTicketProcessor = new LuckyTicketProcessor(
                logger,
                luckyTicketResolverFactory
            );

            TicketsTask inputData = InputDataParser.GetTicketsTask(args);

            luckyTicketProcessor.Process(inputData);
        }
    }
}
using Liba.Logger.Implements;
using Liba.Logger.Interfaces;
using LuckyTickets.Business.Tickets;
using LuckyTickets.Model;
using LuckyTickets.Tickets.Resolvers.Implements;
using LuckyTickets.Tickets.Resolvers.Interfaces;

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

            InputData inputData = InputDataParser.GetInputData(args);

            luckyTicketProcessor.Process(inputData);
        }
    }
}
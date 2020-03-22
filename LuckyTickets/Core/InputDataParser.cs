using System.IO;
using Liba.FilesManagers;
using Liba.Validation.Implements;

namespace LuckyTickets.Core
{
    public static class InputDataParser
    {
        public static TicketsTask GetTicketsTask(string[] args)
        {
            var filePath = args[0];

            if (!FileValidator.IsValid(filePath))
                throw new FileNotFoundException($"File '{filePath}' not found");

            var fileManager = new FileManager(filePath);
            var algorithm = fileManager.ReadText();

            return new TicketsTask
            {
                Algorithm = algorithm
            };
        }
    }
}
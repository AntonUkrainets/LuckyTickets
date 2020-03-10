using System.IO;
using Liba.FilesManagers.Implements;
using LuckyTickets.Validation;

namespace LuckyTickets.Model
{
    public static class InputDataParser
    {
        public static InputData GetInputData(string[] args)
        {
            var filePath = args[0];

            if (!Validator.IsFileExists(filePath))
                throw new FileNotFoundException($"File '{filePath}' not found");

            var fileManager = new FileManager(filePath);
            var algorithm = fileManager.ReadText();

            return new InputData
            {
                Algorithm = algorithm
            };
        }
    }
}
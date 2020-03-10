using System.IO;

namespace LuckyTickets.Validation
{
    public static class Validator
    {
        public static bool IsFileExists(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
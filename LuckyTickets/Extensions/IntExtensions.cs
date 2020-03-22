using System.Collections.Generic;

namespace LuckyTickets.Extensions
{
    public static class IntExtensions
    {
        public static IEnumerable<int> SplitToParts(this int numbers)
        {
            var digits = new List<int>();

            while (numbers != 0)
            {
                var value = numbers % 10;
                digits.Add(value);

                numbers /= 10;
            }

            return digits;
        }
    }
}
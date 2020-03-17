namespace LuckyTickets.Business.Models
{
    public class Ticket
    {
        public int Number { get; }

        public Ticket(int number)
        {
            Number = number;
        }
    }
}
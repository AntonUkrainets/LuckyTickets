namespace LuckyTickets.Business.Models
{
    public class Ticket
    {
        public int Number { get; set; }

        public Ticket(int number)
        {
            Number = number;
        }
    }
}
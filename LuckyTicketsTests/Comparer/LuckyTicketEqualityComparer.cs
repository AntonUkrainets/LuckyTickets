using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using LuckyTickets.Business.Models;

namespace LuckyTicketsTests.Comparer
{
    public class LuckyTicketEqualityComparer : EqualityComparer<Ticket>
    {
        public override bool Equals([AllowNull] Ticket a, [AllowNull] Ticket b)
        {
            return a.Number == b.Number;
        }

        public override int GetHashCode([DisallowNull] Ticket obj)
        {
            return obj.GetHashCode();
        }
    }
}
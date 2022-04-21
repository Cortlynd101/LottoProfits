using System;

namespace LottoProfits
{
    public class Ticket
    {
        public int[] ticketNumbers { get; set; }
        public Ticket()
        {
            ticketNumbers = new int[6];
        }

        public Ticket createTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public bool checkDuplicity()
        {
            throw new NotImplementedException();
        }

        public bool checkNumberIsInRange(int p0, int p1)
        {
            throw new NotImplementedException();
        }
    }
}

using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static TicketService()
        {
            Tickets = new List<Ticket>
            {
                new Ticket {ID=1, BookedFor = "PlatinumPlus", Price = 5000, Qty = 5 },
                new Ticket {ID=2, BookedFor = "Gold", Price = 3500, Qty = 10 },
                new Ticket {ID = 3, BookedFor = "Silver", Price = 2000, Qty = 15 }
            };
        }

        public static List<Ticket> GetAll() => Tickets;
        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x=>x.ID == id);
            return ticket;
        }
    }
}

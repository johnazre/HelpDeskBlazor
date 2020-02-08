using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskUI.Data.Tickets
{
    public class TicketService
    {
        private readonly TicketContext _context;
        public TicketService(TicketContext context)
        {
            _context = context;
        }
        public async Task<List<TicketModel>> GetTickets()
        {
            var tickets = _context.Tickets;
            return await Task.FromResult(tickets.ToList());
        }

        public string AddNewTicket(TicketModel ticket)
        {
            _context.Add(ticket);
            _context.SaveChanges();
            return "New ticket added";
        }
    }
}

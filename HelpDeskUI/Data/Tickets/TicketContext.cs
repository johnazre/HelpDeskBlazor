using Microsoft.EntityFrameworkCore;

namespace HelpDeskUI.Data.Tickets
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions options) : base(options) { }

        public DbSet<TicketModel> Tickets { get; set; }
    }
}

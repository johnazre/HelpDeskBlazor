using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskUI.Data.Tickets
{
    public class TicketModel
    {
        public int Id { get; set; }
        public IdentityUser SubmittedBy { get; set; }
        public IdentityUser HandledBy { get; set; }
        public string Message { get; set; }
        public bool IsCurrentlyBeingHandled { get; set; }
        public bool IsComplete { get; set; }
    }
}

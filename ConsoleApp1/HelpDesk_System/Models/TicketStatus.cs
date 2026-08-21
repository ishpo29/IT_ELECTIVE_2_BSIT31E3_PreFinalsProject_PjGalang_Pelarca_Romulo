using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace HelpDesk_System.Models
{
    [Table("TicketStatuses")]
    public class TicketStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsClosed { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace HelpDesk_System.Models
{
    [Table("TicketPriorities")]
    public class TicketPriority
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public int ResponseHours { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
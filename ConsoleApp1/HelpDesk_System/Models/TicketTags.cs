using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("TicketTags")]
    public class TicketTags
    {
        public int TicketId { get; set; }
        public int TagId { get; set; }

        [ForeignKey(nameof(TicketId))]
        public Ticket Ticket { get; set; } = null!;

        [ForeignKey(nameof(TagId))]
        public Tags Tags { get; set; } = null!;
    }
}
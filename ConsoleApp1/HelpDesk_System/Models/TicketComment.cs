using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("TicketComments")]
    public class TicketComment
    {
        public int Id { get; set; }

        public int TicketId { get; set; }
        public int? EmployeeId { get; set; }

        public string Comment { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public bool IsInternal { get; set; }

        [ForeignKey(nameof(TicketId))]
        public Ticket Ticket { get; set; } = null!;

        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }
    }
}
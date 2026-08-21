using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("TicketAssignments")]
    public class TicketAssignment
    {
        public int TicketId { get; set; }
        public int EmployeeId { get; set; }
        public string AssignedAt { get; set; } = string.Empty;
        public string? UnassignedAt { get; set; }
        public bool IsPrimary { get; set; }

        [ForeignKey(nameof(TicketId))]
        public Ticket Ticket { get; set; } = null!;

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; } = null!;
    }
}
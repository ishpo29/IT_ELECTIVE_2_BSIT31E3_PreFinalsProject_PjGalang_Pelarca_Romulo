using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public int PriorityId { get; set; }
        public int StatusId { get; set; }

        public string Subject { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string? DueAt { get; set; }
        public string? ResolvedAt { get; set; }
        public string? ClosedAt { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }

        [ForeignKey(nameof(PriorityId))]
        public TicketPriority Priority { get; set; } = null!;

        [ForeignKey(nameof(StatusId))]
        public TicketStatus Status { get; set; } = null!;

        public ICollection<TicketAssignment> TicketAssignments { get; set; } = new List<TicketAssignment>();
        public ICollection<TicketComment> TicketComments { get; set; } = new List<TicketComment>();
        public ICollection<TicketTags> TicketTags { get; set; } = new List<TicketTags>();
        public ICollection<TicketAttachment> TicketAttachments { get; set; } = new List<TicketAttachment>();
    }
}
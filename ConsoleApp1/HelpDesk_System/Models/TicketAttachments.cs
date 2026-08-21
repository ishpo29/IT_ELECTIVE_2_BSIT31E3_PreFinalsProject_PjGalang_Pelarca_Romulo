using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("TicketAttachments")]
    public class TicketAttachment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public string UploadedAt { get; set; } = string.Empty;

        [ForeignKey(nameof(TicketId))]
        public Ticket Ticket { get; set; } = null!;
    }
}
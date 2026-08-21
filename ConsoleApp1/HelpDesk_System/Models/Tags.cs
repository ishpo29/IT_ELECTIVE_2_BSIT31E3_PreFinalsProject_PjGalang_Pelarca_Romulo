using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("Tags")]
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<TicketTags> TicketTags { get; set; } = new List<TicketTags>();
    }
}
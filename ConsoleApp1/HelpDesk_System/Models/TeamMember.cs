using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk_System.Models
{
    [Table("TeamMembers")]
    public class TeamMember
    {
        public int TeamId { get; set; }
        public int EmployeeId { get; set; }
        public string JoinedAt { get; set; } = string.Empty;

        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; } = null!;

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; } = null!;
    }
}
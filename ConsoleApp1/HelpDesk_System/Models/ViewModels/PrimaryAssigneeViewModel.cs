namespace HelpDesk_System.Models.ViewModels
{
    public class PrimaryAssigneeViewModel
    {
        public int TicketId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string PrimaryAssignee { get; set; } = string.Empty;
    }
}
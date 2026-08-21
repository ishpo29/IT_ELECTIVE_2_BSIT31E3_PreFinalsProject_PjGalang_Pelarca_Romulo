namespace HelpDesk_System.Models.ViewModels
{
    public class MultipleAssigneeTicketViewModel
    {
        public int TicketId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public int ActiveAssigneeCount { get; set; }
        public List<string> Assignees { get; set; } = new();
    }
}
namespace HelpDesk_System.Models.ViewModels
{
    public class DepartmentWorkloadViewModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int EmployeeCount { get; set; }
        public int UnresolvedTicketCount { get; set; }
    }
}

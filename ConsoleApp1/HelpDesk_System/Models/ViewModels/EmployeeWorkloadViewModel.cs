namespace HelpDesk_System.Models.ViewModels
{
    public class EmployeeWorkloadViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public int UnresolvedTicketCount { get; set; }
    }
}
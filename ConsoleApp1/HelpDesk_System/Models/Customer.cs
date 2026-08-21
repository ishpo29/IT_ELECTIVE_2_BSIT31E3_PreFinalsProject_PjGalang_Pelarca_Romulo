namespace HelpDesk_System.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string CreatedAt { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
namespace HelpDesk_System.Models.ViewModels
{
    public class CategoryHierarchyViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string ParentCategoryName { get; set; } = string.Empty;
    }
}
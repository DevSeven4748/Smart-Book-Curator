namespace BookCurator.MVC.Models.ViewModels
{
    public class DashboardViewModel
    {
        public int BookCount { get; set; }
        public int MovieCount { get; set; }
        public int TvShowCount { get; set; }
        public List<RecentItem> RecentItems { get; set; } = new();
    }

    public class RecentItem
    {
        public string MediaType { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
    }
}
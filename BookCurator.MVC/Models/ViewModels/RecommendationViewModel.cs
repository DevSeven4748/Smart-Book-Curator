namespace BookCurator.MVC.Models.ViewModels
{
    public class RecommendationViewModel
    {
        public string? Mood { get; set; }
        public string? Result { get; set; }
        public int ItemCount { get; set; }
        public bool IsLoading { get; set; }
    }
}

namespace BookCurator.BLL.Models
{
    public class MediaSummary
    {
        public string MediaType { get; set; } = string.Empty; // "Book", "Movie", "TvShow"
        public string Title { get; set; } = string.Empty;
        public string Creator { get; set; } = string.Empty;   // Author or Director, empty for TvShow
        public string Genre { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int? Rating { get; set; }
    }
}
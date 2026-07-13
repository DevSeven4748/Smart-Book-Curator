namespace BookCurator.DAL.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public WatchStatus Status { get; set; } = WatchStatus.ToWatch;
        public int? Rating { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateFinished { get; set; }
    }
}
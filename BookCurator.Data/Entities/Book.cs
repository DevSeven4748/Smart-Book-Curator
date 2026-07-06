namespace BookCurator.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public BookStatus Status { get; set; }
        public int? Rating { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime CreatedAt { get; set; }

    }

    public enum BookStatus
    {
        ToRead,
        Reading,
        Finished
    }
}

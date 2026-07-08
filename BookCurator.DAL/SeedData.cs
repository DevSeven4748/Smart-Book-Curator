using BookCurator.DAL.Entities;

namespace BookCurator.DAL
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Books.Any())
                return;

            var books = new List<Book>
            {
                new Book
                {
                    Title = "Dune",
                    Author = "Frank Herbert",
                    Genre = "Sci-Fi",
                    Status = BookStatus.Finished,
                    Rating = 5,
                    Notes = "Reread every few years.",
                    DateAdded = DateTime.Now.AddMonths(-6),
                    DateFinished = DateTime.Now.AddMonths(-5)
                },
                new Book
                {
                    Title = "Atomic Habits",
                    Author = "James Clear",
                    Genre = "Self-Help",
                    Status = BookStatus.Reading,
                    Rating = 4,
                    Notes = "Implementing the 2-minute rule daily.",
                    DateAdded = DateTime.Now.AddDays(-14),
                    DateFinished = null
                },
                new Book
                {
                    Title = "The Silent Patient",
                    Author = "Alex Michaelides",
                    Genre = "Thriller",
                    Status = BookStatus.Finished,
                    Rating = 4,
                    Notes = "Incredible plot twist at the end.",
                    DateAdded = DateTime.Now.AddMonths(-2),
                    DateFinished = DateTime.Now.AddMonths(-1)
                },
                new Book
                {
                    Title = "Sapiens",
                    Author = "Yuval Noah Harari",
                    Genre = "History",
                    Status = BookStatus.ToRead,
                    Rating = 0,
                    Notes = "Highly recommended by friends.",
                    DateAdded = DateTime.Now.AddDays(-5),
                    DateFinished = null
                },
                new Book
                {
                    Title = "Project Hail Mary",
                    Author = "Andy Weir",
                    Genre = "Sci-Fi",
                    Status = BookStatus.Finished,
                    Rating = 5,
                    Notes = "Fascinating science and a great duo.",
                    DateAdded = DateTime.Now.AddMonths(-4),
                    DateFinished = DateTime.Now.AddMonths(-3)
                },
                new Book
                {
                    Title = "Thinking, Fast and Slow",
                    Author = "Daniel Kahneman",
                    Genre = "Psychology",
                    Status = BookStatus.Reading,
                    Rating = 5,
                    Notes = "Dense but incredibly eye-opening.",
                    DateAdded = DateTime.Now.AddMonths(-1),
                    DateFinished = null
                },
                new Book
                {
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Genre = "Fantasy",
                    Status = BookStatus.Finished,
                    Rating = 5,
                    Notes = "A timeless classic comfort read.",
                    DateAdded = DateTime.Now.AddYears(-1),
                    DateFinished = DateTime.Now.AddYears(-1).AddMonths(1)
                },
                new Book
                {
                    Title = "Educated",
                    Author = "Tara Westover",
                    Genre = "Biography",
                    Status = BookStatus.Finished,
                    Rating = 4,
                    Notes = "Unbelievable life story and resilience.",
                    DateAdded = DateTime.Now.AddMonths(-8),
                    DateFinished = DateTime.Now.AddMonths(-7)
                },
                new Book
                {
                    Title = "Bad Blood",
                    Author = "John Carreyrou",
                    Genre = "True Crime",
                    Status = BookStatus.Finished,
                    Rating = 5,
                    Notes = "The Theranos scandal is wild.",
                    DateAdded = DateTime.Now.AddMonths(-3),
                    DateFinished = DateTime.Now.AddMonths(-2)
                },
                new Book
                {
                    Title = "The Midnight Library",
                    Author = "Matt Haig",
                    Genre = "Fiction",
                    Status = BookStatus.ToRead,
                    Rating = 0,
                    Notes = "Interesting premise about parallel lives.",
                    DateAdded = DateTime.Now.AddDays(-2),
                    DateFinished = null
                },
                new Book
                {
                    Title = "Deep Work",
                    Author = "Cal Newport",
                    Genre = "Productivity",
                    Status = BookStatus.Finished,
                    Rating = 4,
                    Notes = "Changed how I structure my workdays.",
                    DateAdded = DateTime.Now.AddMonths(-5),
                    DateFinished = DateTime.Now.AddMonths(-4)
                },
                new Book
                {
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Genre = "Philosophy",
                    Status = BookStatus.Finished,
                    Rating = 3,
                    Notes = "A bit simple, but good reminders.",
                    DateAdded = DateTime.Now.AddMonths(-12),
                    DateFinished = DateTime.Now.AddMonths(-11)
                },
                new Book
                {
                    Title = "Circe",
                    Author = "Madeline Miller",
                    Genre = "Mythology",
                    Status = BookStatus.Reading,
                    Rating = 4,
                    Notes = "Beautiful prose and world-building.",
                    DateAdded = DateTime.Now.AddDays(-20),
                    DateFinished = null
                },
                new Book
                {
                    Title = "Clean Code",
                    Author = "Robert C. Martin",
                    Genre = "Technical",
                    Status = BookStatus.Finished,
                    Rating = 4,
                    Notes = "Essential reading for development.",
                    DateAdded = DateTime.Now.AddMonths(-10),
                    DateFinished = DateTime.Now.AddMonths(-8)
                },
                new Book
                {
                    Title = "The Thursday Murder Club",
                    Author = "Richard Osman",
                    Genre = "Mystery",
                    Status = BookStatus.Finished,
                    Rating = 4,
                    Notes = "Charming, witty, and very British.",
                    DateAdded = DateTime.Now.AddMonths(-2),
                    DateFinished = DateTime.Now.AddMonths(-2).AddDays(15)
                },
                new Book
                {
                    Title = "Klara and the Sun",
                    Author = "Kazuo Ishiguro",
                    Genre = "Dystopian",
                    Status = BookStatus.ToRead,
                    Rating = 0,
                    Notes = "AI perspective story, sounds unique.",
                    DateAdded = DateTime.Now.AddDays(-1),
                    DateFinished = null
                },
                new Book
                {
                    Title = "Shoe Dog",
                    Author = "Phil Knight",
                    Genre = "Business",
                    Status = BookStatus.Finished,
                    Rating = 5,
                    Notes = "The chaotic history behind Nike.",
                    DateAdded = DateTime.Now.AddMonths(-7),
                    DateFinished = DateTime.Now.AddMonths(-6)
                },
                new Book
                {
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Genre = "Classic",
                    Status = BookStatus.Finished,
                    Rating = 4,
                    Notes = "Classic tragedy with amazing symbolism.",
                    DateAdded = DateTime.Now.AddYears(-2),
                    DateFinished = DateTime.Now.AddYears(-2).AddMonths(1)
                },
                new Book
                {
                    Title = "Neuromancer",
                    Author = "William Gibson",
                    Genre = "Cyberpunk",
                    Status = BookStatus.Reading,
                    Rating = 3,
                    Notes = "The origin of cyberspace concepts.",
                    DateAdded = DateTime.Now.AddDays(-7),
                    DateFinished = null
                },
                new Book
                {
                    Title = "Meditations",
                    Author = "Marcus Aurelius",
                    Genre = "Philosophy",
                    Status = BookStatus.Finished,
                    Rating = 5,
                    Notes = "Timeless stoic advice.",
                    DateAdded = DateTime.Now.AddMonths(-9),
                    DateFinished = DateTime.Now.AddMonths(-8)
                }
            };

            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
}
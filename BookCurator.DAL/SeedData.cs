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
                    Rating = null,
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
                    Rating = null,
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
                    Rating = null,
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

            if (context.Movies.Any())
                return;

            var movies = new List<Movie>
            {
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    Director = "Frank Darabont",
                    Genre = "Drama",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "An absolute masterpiece. Incredible ending.",
                    DateAdded = DateTime.Now.AddMonths(-5),
                    DateFinished = DateTime.Now.AddMonths(-5)
                },
                new Movie
                {
                    Title = "Inception",
                    Director = "Christopher Nolan",
                    Genre = "Sci-Fi",
                    Status = WatchStatus.Watching,
                    Rating = 5,
                    Notes = "Mind-bending concept, great score by Hans Zimmer.",
                    DateAdded = DateTime.Now.AddMonths(-4),
                    DateFinished = null
                },
                new Movie
                {
                    Title = "The Godfather",
                    Director = "Francis Ford Coppola",
                    Genre = "Crime",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Classic cinema at its finest.",
                    DateAdded = DateTime.Now.AddMonths(-6),
                    DateFinished = DateTime.Now.AddMonths(-6)
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    Director = "Quentin Tarantino",
                    Genre = "Crime",
                    Status = WatchStatus.ToWatch,
                    Rating = null,
                    Notes = "Iconic dialogues and non-linear storytelling.",
                    DateAdded = DateTime.Now.AddMonths(-3),
                    DateFinished = null
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    Director = "Christopher Nolan",
                    Genre = "Action",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Heath Ledger's performance as Joker is unmatched.",
                    DateAdded = DateTime.Now.AddMonths(-2),
                    DateFinished = DateTime.Now.AddMonths(-2)
                },
                new Movie
                {
                    Title = "Interstellar",
                    Director = "Christopher Nolan",
                    Genre = "Sci-Fi",
                    Status = WatchStatus.ToWatch,
                    Rating = null,
                    Notes = "Visually stunning and emotionally heavy.",
                    DateAdded = DateTime.Now.AddMonths(-7),
                    DateFinished = null
                },
                new Movie
                {
                    Title = "Fight Club",
                    Director = "David Fincher",
                    Genre = "Drama",
                    Status = WatchStatus.Watching,
                    Rating = 4,
                    Notes = "Great plot twist, very philosophical.",
                    DateAdded = DateTime.Now.AddMonths(-1),
                    DateFinished = null
                },
                new Movie
                {
                    Title = "The Matrix",
                    Director = "Lana Wachowski",
                    Genre = "Sci-Fi",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Revolutionary for its time.",
                    DateAdded = DateTime.Now.AddMonths(-8),
                    DateFinished = DateTime.Now.AddMonths(-8)
                },
                new Movie
                {
                    Title = "Goodfellas",
                    Director = "Martin Scorsese",
                    Genre = "Crime",
                    Status = WatchStatus.ToWatch,
                    Rating = null,
                    Notes = "One of the best mob movies ever made.",
                    DateAdded = DateTime.Now.AddMonths(-2),
                    DateFinished = null
                },
                new Movie
                {
                    Title = "Se7en",
                    Director = "David Fincher",
                    Genre = "Thriller",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "What's in the box?! Devastating ending.",
                    DateAdded = DateTime.Now.AddMonths(-3),
                    DateFinished = DateTime.Now.AddMonths(-3)
                },
                new Movie
                {
                    Title = "Whiplash",
                    Director = "Damien Chazelle",
                    Genre = "Drama",
                    Status = WatchStatus.Watching,
                    Rating = 5,
                    Notes = "The tension in this movie is insane. Not quite my tempo.",
                    DateAdded = DateTime.Now.AddMonths(-4),
                    DateFinished = null
                },
                new Movie
                {
                    Title = "Spirited Away",
                    Director = "Hayao Miyazaki",
                    Genre = "Animation",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Beautifully animated and magical story.",
                    DateAdded = DateTime.Now.AddMonths(-9),
                    DateFinished = DateTime.Now.AddMonths(-9)
                },
                new Movie
                {
                    Title = "Parasite",
                    Director = "Bong Joon Ho",
                    Genre = "Thriller",
                    Status = WatchStatus.ToWatch,
                    Rating = null,
                    Notes = "Deserved every Oscar it won. Great social commentary.",
                    DateAdded = DateTime.Now.AddMonths(-1),
                    DateFinished = null
                },
                new Movie
                {
                    Title = "Gladiator",
                    Director = "Ridley Scott",
                    Genre = "Action",
                    Status = WatchStatus.Finished,
                    Rating = 4,
                    Notes = "Are you not entertained? Epic historical drama.",
                    DateAdded = DateTime.Now.AddMonths(-10),
                    DateFinished = DateTime.Now.AddMonths(-10)
                },
                new Movie
                {
                    Title = "Forrest Gump",
                    Director = "Robert Zemeckis",
                    Genre = "Drama",
                    Status = WatchStatus.Watching,
                    Rating = 5,
                    Notes = "Life is like a box of chocolates. Heartwarming story.",
                    DateAdded = DateTime.Now.AddMonths(-11),
                    DateFinished = null
                }
            };

            if (context.TvShows.Any())
                return;
            
            var tvShows = new List<TvShow>
            {
                new TvShow
                {
                    Title = "Breaking Bad",
                    Genre = "Crime",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "The best TV series ever created from start to finish.",
                    DateAdded = DateTime.Now.AddMonths(-12),
                    DateFinished = DateTime.Now.AddMonths(-10)
                },
                new TvShow
                {
                    Title = "Game of Thrones",
                    Genre = "Fantasy",
                    Status = WatchStatus.Watching,
                    Rating = 4,
                    Notes = "Amazing first 6 seasons, rushed ending but still a must-watch.",
                    DateAdded = DateTime.Now.AddMonths(-15),
                    DateFinished = null
                },
                new TvShow
                {
                    Title = "Chernobyl",
                    Genre = "Drama",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Atmospheric, terrifying, and brilliantly acted mini-series.",
                    DateAdded = DateTime.Now.AddMonths(-3),
                    DateFinished = DateTime.Now.AddMonths(-3)
                },
                new TvShow
                {
                    Title = "The Wire",
                    Genre = "Crime",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Incredibly realistic look at city institutions.",
                    DateAdded = DateTime.Now.AddMonths(-24),
                    DateFinished = DateTime.Now.AddMonths(-20)
                },
                new TvShow
                {
                    Title = "Stranger Things",
                    Genre = "Sci-Fi",
                    Status = WatchStatus.Watching,
                    Rating = 4,
                    Notes = "Great 80s nostalgia and lovable characters.",
                    DateAdded = DateTime.Now.AddMonths(-6),
                    DateFinished = null
                },
                new TvShow
                {
                    Title = "Friends",
                    Genre = "Comedy",
                    Status = WatchStatus.ToWatch,
                    Rating = null,
                    Notes = "Comfort show. Great to put on in the background.",
                    DateAdded = DateTime.Now.AddMonths(-18),
                    DateFinished = null
                },
                new TvShow
                {
                    Title = "The Office",
                    Genre = "Comedy",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Michael Scott is legendary. Funniest mockumentary.",
                    DateAdded = DateTime.Now.AddMonths(-8),
                    DateFinished = DateTime.Now.AddMonths(-6)
                },
                new TvShow
                {
                    Title = "Better Call Saul",
                    Genre = "Crime",
                    Status = WatchStatus.Watching,
                    Rating = 5,
                    Notes = "A masterpiece spin-off that lives up to Breaking Bad.",
                    DateAdded = DateTime.Now.AddMonths(-7),
                    DateFinished = null
                },
                new TvShow
                {
                    Title = "True Detective",
                    Genre = "Thriller",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Season 1 is absolute perfection. Matthew McConaughey shines.",
                    DateAdded = DateTime.Now.AddMonths(-4),
                    DateFinished = DateTime.Now.AddMonths(-4)
                },
                new TvShow
                {
                    Title = "Fargo",
                    Genre = "Crime",
                    Status = WatchStatus.ToWatch,
                    Rating = null,
                    Notes = "Great anthology series with dark humor.",
                    DateAdded = DateTime.Now.AddMonths(-5),
                    DateFinished = null
                },
                new TvShow
                {
                    Title = "Succession",
                    Genre = "Drama",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Incredible writing, acting, and background music.",
                    DateAdded = DateTime.Now.AddMonths(-9),
                    DateFinished = DateTime.Now.AddMonths(-8)
                },
                new TvShow
                {
                    Title = "Dark",
                    Genre = "Sci-Fi",
                    Status = WatchStatus.Watching,
                    Rating = 5,
                    Notes = "Complex time travel plot that actually makes sense at the end.",
                    DateAdded = DateTime.Now.AddMonths(-10),
                    DateFinished = null
                },
                new TvShow
                {
                    Title = "Black Mirror",
                    Genre = "Sci-Fi",
                    Status = WatchStatus.ToWatch,
                    Rating = null,
                    Notes = "Dystopian tech anthology. Some episodes are pure art.",
                    DateAdded = DateTime.Now.AddMonths(-6),
                    DateFinished = null
                },
                new TvShow
                {
                    Title = "Mindhunter",
                    Genre = "Thriller",
                    Status = WatchStatus.Finished,
                    Rating = 5,
                    Notes = "Fascinating look into the psychology of serial killers.",
                    DateAdded = DateTime.Now.AddMonths(-3),
                    DateFinished = DateTime.Now.AddMonths(-3)
                },
                new TvShow
                {
                    Title = "Peaky Blinders",
                    Genre = "Crime",
                    Status = WatchStatus.ToWatch,
                    Rating = null,
                    Notes = "By order of the Peaky Blinders! Cillian Murphy is great.",
                    DateAdded = DateTime.Now.AddMonths(-11),
                    DateFinished = null
                }
            };

            context.Books.AddRange(books);
            context.Movies.AddRange(movies);
            context.TvShows.AddRange(tvShows);
            context.SaveChanges();
        }
    }
}
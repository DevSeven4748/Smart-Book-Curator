using Microsoft.EntityFrameworkCore;
using BookCurator.DAL.Repositories.Abstract;
using BookCurator.DAL.Entities;

namespace BookCurator.DAL.Repositories.Concrete
{
    public class MovieRepository(AppDbContext context) : IMovieRepository
    {
        public async Task<IEnumerable<Movie>> GetAllAsync() => await context.Movies.OrderByDescending(m => m.DateAdded).ToListAsync();

        public async Task<Movie?> GetByIdAsync(int id) => await context.Movies.FindAsync(id);

        public async Task AddAsync(Movie movie) => await context.Movies.AddAsync(movie);

        public void Delete(Movie movie) => context.Movies.Remove(movie);

        public void Update(Movie movie) => context.Movies.Update(movie);

        public async Task<bool> SaveChangesAsync() => (await context.SaveChangesAsync()) > 0;
    }
}
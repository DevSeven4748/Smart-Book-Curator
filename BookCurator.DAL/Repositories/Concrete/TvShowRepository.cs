using Microsoft.EntityFrameworkCore;
using BookCurator.DAL.Repositories.Abstract;
using BookCurator.DAL.Entities;

namespace BookCurator.DAL.Repositories.Concrete
{
    public class TvShowRepository(AppDbContext context) : ITvShowRepository
    {
        public async Task<IEnumerable<TvShow>> GetAllAsync() => await context.TvShows.OrderByDescending(m => m.DateAdded).ToListAsync();

        public async Task<TvShow?> GetByIdAsync(int id) => await context.TvShows.FindAsync(id);

        public async Task AddAsync(TvShow tvShow) => await context.TvShows.AddAsync(tvShow);

        public void Delete(TvShow tvShow) => context.TvShows.Remove(tvShow);

        public void Update(TvShow tvShow) => context.TvShows.Update(tvShow);

        public async Task<bool> SaveChangesAsync() => (await context.SaveChangesAsync()) > 0;
    }
}
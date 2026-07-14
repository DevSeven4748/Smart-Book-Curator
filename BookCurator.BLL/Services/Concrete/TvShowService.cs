using BookCurator.BLL.Services.Abstract;
using BookCurator.DAL.Entities;
using BookCurator.DAL.Repositories.Abstract;

namespace BookCurator.BLL.Services.Concrete
{
    public class TvShowService(ITvShowRepository repository) : ITvShowService
    {
        public async Task<IEnumerable<TvShow>> GetAllTvShowsAsync() =>
            await repository.GetAllAsync();

        public async Task<TvShow?> GetTvShowByIdAsync(int id) =>
            await repository.GetByIdAsync(id);

        public async Task AddTvShowAsync(TvShow tvShow)
        {
            await repository.AddAsync(tvShow);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateTvShowAsync(TvShow tvShow)
        {
            repository.Update(tvShow);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteTvShowAsync(int id)
        {
            var tvShow = await repository.GetByIdAsync(id);
            if (tvShow != null)
            {
                repository.Delete(tvShow);
                await repository.SaveChangesAsync();
            }
        }
    }
}
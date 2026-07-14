using BookCurator.DAL.Entities;

namespace BookCurator.BLL.Services.Abstract
{
    public interface ITvShowService
    {
        Task<IEnumerable<TvShow>> GetAllTvShowsAsync();
        Task<TvShow?> GetTvShowByIdAsync(int id);
        Task AddTvShowAsync(TvShow tvShow);
        Task UpdateTvShowAsync(TvShow tvShow);
        Task DeleteTvShowAsync(int id);
    }
}
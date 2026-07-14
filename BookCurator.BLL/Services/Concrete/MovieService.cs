using BookCurator.BLL.Services.Abstract;
using BookCurator.DAL.Entities;
using BookCurator.DAL.Repositories.Abstract;

namespace BookCurator.BLL.Services.Concrete
{
    public class MovieService(IMovieRepository repository) : IMovieService
    {
        public async Task<IEnumerable<Movie>> GetAllMoviesAsync() =>
            await repository.GetAllAsync();

        public async Task<Movie?> GetMovieByIdAsync(int id) =>
            await repository.GetByIdAsync(id);

        public async Task AddMovieAsync(Movie movie)
        {
            await repository.AddAsync(movie);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            repository.Update(movie);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteMovieAsync(int id)
        {
            var movie = await repository.GetByIdAsync(id);
            if (movie != null)
            {
                repository.Delete(movie);
                await repository.SaveChangesAsync();
            }
        }
    }
}
using BookCurator.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookCurator.DAL.Repositories.Abstract
{
    public interface ITvShowRepository
    {
        Task<IEnumerable<TvShow>> GetAllAsync();
        Task<TvShow?> GetByIdAsync(int id);
        Task AddAsync(TvShow tvShow);
        void Update(TvShow tvShow);
        void Delete(TvShow tvShow);
        Task<bool> SaveChangesAsync();
    }
}

using BookCurator.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookCurator.BLL.Services.Abstract
{
    public interface IRecommendationService
    {
        Task<string> GetRecommendationAsync(IEnumerable<Book> books, string? mood);
    }
}

using BookCurator.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookCurator.BLL.Services.Abstract
{
    public interface  IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book?> GetBookByIdAsync(int id);
        Task CreateBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(int id);


    }
}

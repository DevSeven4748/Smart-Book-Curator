using BookCurator.BLL.Services.Abstract;
using BookCurator.DAL.Entities;
using BookCurator.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookCurator.BLL.Services.Concrete
{
    public class BookService(IBookRepository repository) : IBookService
    {
        public async Task<IEnumerable<Book>> GetAllBooksAsync() => await repository.GetAllAsync();

        public async Task<Book?> GetBookByIdAsync(int id) => await repository.GetByIdAsync(id);

        public async Task CreateBookAsync(Book book)
        {
            await repository.AddAsync(book);
            await repository.SaveChangesAsync();
        }
        public async Task UpdateBookAsync(Book book)
        {
            repository.Update(book);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await repository.GetByIdAsync(id);
            if(book != null)
            {
                repository.Delete(book);
                await repository.SaveChangesAsync();
            }

        }


    }
}

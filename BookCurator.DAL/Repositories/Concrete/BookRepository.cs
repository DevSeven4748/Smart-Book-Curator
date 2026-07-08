using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BookCurator.DAL.Repositories.Abstract;
using BookCurator.DAL;
using BookCurator.DAL.Entities;

namespace BookCurator.DAL.Repositories.Concrete
{
    public class BookRepository(AppDbContext context) : IBookRepository
    {

        public async Task<IEnumerable<Book>> GetAllAsync() => 
            await context.Books.OrderByDescending(b => b.DateAdded).ToListAsync();

        public async Task<Book?> GetByIdAsync(int id) => await context.Books.FindAsync(id);

        public async Task AddAsync(Book book) => await context.Books.AddAsync(book);

        public void Delete(Book book) => context.Books.Remove(book);

        public void Update(Book book) => context.Books.Update(book);

        public async Task<bool> SaveChangesAsync() => (await context.SaveChangesAsync()) > 0; //savechanges returns the amount ve lines that were affected, so if it is greater than 0, it means that something was changed and saved to the database

    }
}

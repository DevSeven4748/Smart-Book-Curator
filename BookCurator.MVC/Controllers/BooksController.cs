using BookCurator.BLL.Services.Abstract;
using BookCurator.BLL.Services.Concrete;
using BookCurator.DAL;
using BookCurator.DAL.Entities;
using BookCurator.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookCurator.MVC.Controllers
{
    public class BooksController(IBookService bookService) : Controller
    {
        // GET: /Books
        public async Task<IActionResult> Index()
        {
            var books = await bookService.GetAllBooksAsync();
            return View(books);
        }

        // GET: /Books/Create
        public async Task<IActionResult> Create()
        {
            return View(new BookCreateViewModel());
        }

        // POST: /Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var book = new Book
            {
                Title = model.Title,
                Author = model.Author,
                Genre = model.Genre,
                Status = model.Status,
                Rating = model.Rating,
                DateAdded = DateTime.UtcNow
            };

            await bookService.CreateBookAsync(book);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Books/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var book = await bookService.GetBookByIdAsync(id);
            if (book == null) return NotFound();

            var model = new BookEditViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Status = book.Status,
                Rating = book.Rating
            };

            return View(model);

        }

        // POST: /Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BookEditViewModel model)
        {
            if (id != model.Id) return NotFound();
            if (!ModelState.IsValid) return View(model);

            var book = await bookService.GetBookByIdAsync(id);
            if (book == null) return NotFound();

            book.Title = model.Title;
            book.Author = model.Author;
            book.Genre = model.Genre;
            book.Status = model.Status;
            book.Rating = model.Rating;

            await bookService.UpdateBookAsync(book);
            return RedirectToAction(nameof(Index));

        }

        // GET: /Books/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var book = await bookService.GetBookByIdAsync(id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await bookService.DeleteBookAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}

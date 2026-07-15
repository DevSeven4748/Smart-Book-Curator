using BookCurator.BLL.Services.Abstract;
using BookCurator.BLL.Services.Concrete;
using BookCurator.DAL.Entities;
using BookCurator.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookCurator.MVC.Controllers
{
    public class MoviesController(IMovieService movieService) : Controller
    {
        // GET: /Movies
        public async Task<IActionResult> Index()
        {
            var movies = await movieService.GetAllMoviesAsync();
            return View(movies);
        }

        // GET: /Movies/Create
        public async Task<IActionResult> Create()
        {
            return View(new MovieCreateViewModel());
        }

        // POST: /Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var movie = new Movie
            {
                Title = model.Title,
                Director = model.Director,
                Genre = model.Genre,
                Status = model.Status,
                Rating = model.Rating,
                DateAdded = DateTime.UtcNow
            };

            await movieService.AddMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Books/Edit/5
        [HttpGet]
        public async Task<IActionResult>  Edit(int id)
        {
            var movie = await movieService.GetMovieByIdAsync(id);
            if (movie == null) return NotFound();

            var model = new MovieEditViewModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Director = movie.Director,
                Genre = movie.Genre,
                Status = movie.Status,
                Rating = movie.Rating

            };

            return View(model);
        }

        // POST: /Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MovieEditViewModel model)
        {
            if (id != model.Id) return NotFound();
            if (!ModelState.IsValid) return View(model);

            var movie = await movieService.GetMovieByIdAsync(id);
            if (movie == null) return NotFound();

            movie.Title = model.Title;
            movie.Director = model.Director;
            movie.Genre = model.Genre;
            movie.Status = model.Status;
            movie.Rating = model.Rating;

            await movieService.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await movieService.GetMovieByIdAsync(id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await movieService.DeleteMovieAsync(id);
            return RedirectToAction(nameof(Index));
        }








    }
}

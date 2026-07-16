using BookCurator.BLL.Services.Abstract;
using BookCurator.BLL.Services.Concrete;
using BookCurator.DAL.Entities;
using BookCurator.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookCurator.MVC.Controllers
{
    public class TvShowsController(ITvShowService tvShowService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            //GET: /TvShows
            var tvShows = await tvShowService.GetAllTvShowsAsync();
            return View(tvShows);
        }

        // GET: /TvShows/Create
        public async Task<IActionResult> Create()
        {
            return View(new TvShowCreateViewModel());
        }

        // POST: /TvShows/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TvShowCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var tvShow = new TvShow
            {
                Title = model.Title,
                Genre = model.Genre,
                Status = model.Status,
                Rating = model.Rating,
                DateAdded = DateTime.UtcNow
            };

            await tvShowService.AddTvShowAsync(tvShow);
            return RedirectToAction(nameof(Index));
        }

        // GET: /TvShows/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var tvShow = await tvShowService.GetTvShowByIdAsync(id);
            if (tvShow == null) return NotFound();

            var model = new TvShowEditViewModel
            {
                Id = tvShow.Id,
                Title = tvShow.Title,
                Genre = tvShow.Genre,
                Status = tvShow.Status,
                Rating = tvShow.Rating
            };
            return View(model);
        }

        // POST: /TvShows/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TvShowEditViewModel model)
        {
            if (id != model.Id) return NotFound();
            if(!ModelState.IsValid) return View(model);

            var tvShow = await tvShowService.GetTvShowByIdAsync(id);
            if (tvShow == null) return NotFound();

            tvShow.Title = model.Title;
            tvShow.Genre = model.Genre;
            tvShow.Rating = model.Rating;
            tvShow.Status = model.Status;

            await tvShowService.UpdateTvShowAsync(tvShow);
            return RedirectToAction(nameof(Index));
        }

        // GET: /TvShows/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var tvShow = await tvShowService.GetTvShowByIdAsync(id);
            if (tvShow == null) return NotFound();

            return View(tvShow);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await tvShowService.DeleteTvShowAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

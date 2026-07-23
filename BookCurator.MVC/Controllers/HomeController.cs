using BookCurator.BLL.Services.Abstract;
using BookCurator.Models;
using BookCurator.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookCurator.Controllers;

public class HomeController(IBookService bookService, IMovieService movieService, ITvShowService tvShowService) : Controller
{
    public async Task<IActionResult> Index()
    {
        var books = await bookService.GetAllBooksAsync();
        var movies = await movieService.GetAllMoviesAsync();
        var shows = await tvShowService.GetAllTvShowsAsync();

        var recent = new List<RecentItem>();

        recent.AddRange(books.Select(b => new RecentItem { MediaType = "Book", Title = b.Title, Status = b.Status.ToString(), DateAdded = b.DateAdded }));
        recent.AddRange(movies.Select(m => new RecentItem { MediaType = "Movie", Title = m.Title, Status = m.Status.ToString(), DateAdded = m.DateAdded }));
        recent.AddRange(shows.Select(s => new RecentItem { MediaType = "TV Show", Title = s.Title, Status = s.Status.ToString(), DateAdded = s.DateAdded }));

        var model = new DashboardViewModel
        {
            BookCount = books.Count(),
            MovieCount = movies.Count(),
            TvShowCount = shows.Count(),
            RecentItems = recent.OrderByDescending(r => r.DateAdded).Take(9).ToList()
        };

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}

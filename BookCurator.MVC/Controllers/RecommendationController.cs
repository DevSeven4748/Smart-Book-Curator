using BookCurator.BLL.DTOs;
using BookCurator.BLL.Services.Abstract;
using BookCurator.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class RecommendationController(
    IRecommendationService recService,
    IBookService bookService,
    IMovieService movieService,
    ITvShowService tvShowService) : Controller
{
    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var items = await GatherMediaSummariesAsync();
        return View(new RecommendationViewModel { ItemCount = items.Count });
    }

    [HttpPost("")]
    public async Task<IActionResult> Index(RecommendationViewModel model)
    {
        var items = await GatherMediaSummariesAsync();
        model.ItemCount = items.Count;
        model.Result = await recService.GetRecommendationAsync(items, model.Mood);
        return View(model);
    }

    //-------------------------------------------------------------------------------
    private async Task<List<MediaSummary>> GatherMediaSummariesAsync()
    {
        var books = await bookService.GetAllBooksAsync();
        var movies = await movieService.GetAllMoviesAsync();
        var shows = await tvShowService.GetAllTvShowsAsync();

        var summaries = new List<MediaSummary>();

        summaries.AddRange(books.Select(b => new MediaSummary
        {
            MediaType = "Book",
            Title = b.Title,
            Creator = b.Author,
            Genre = b.Genre,
            Status = b.Status.ToString(),
            Rating = b.Rating
        }));

        summaries.AddRange(movies.Select(m => new MediaSummary
        {
            MediaType = "Movie",
            Title = m.Title,
            Creator = m.Director,
            Genre = m.Genre,
            Status = m.Status.ToString(),
            Rating = m.Rating
        }));

        summaries.AddRange(shows.Select(s => new MediaSummary
        {
            MediaType = "TvShow",
            Title = s.Title,
            Creator = "",
            Genre = s.Genre,
            Status = s.Status.ToString(),
            Rating = s.Rating
        }));

        return summaries;
    }
}
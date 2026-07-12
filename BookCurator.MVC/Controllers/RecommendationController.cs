using BookCurator.BLL.Services.Abstract;
using BookCurator.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookCurator.Controllers;

[Route("[controller]")]
public class RecommendationController(IRecommendationService recService, IBookService bookService) : Controller
{
    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var books = await bookService.GetAllBooksAsync();
        return View(new RecommendationViewModel { BookCount = books.Count()});
    }

    [HttpPost("")]
    public async Task<IActionResult> Index(RecommendationViewModel model)
    {
        var books = await bookService.GetAllBooksAsync();
        model.BookCount = books.Count();
        model.Result = await recService.GetRecommendationAsync(books, model.Mood);
        return View(model);
    }

}
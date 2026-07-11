using BookCurator.BLL.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BookCurator.Controllers;

[Route("[controller]")]
public class RecommendationController(IRecommendationService recService, IBookService bookService) : Controller
{
    [HttpGet("test")]
    public async Task<IActionResult> Test()
    {
        var books = await bookService.GetAllBooksAsync();
        var result = await recService.GetRecommendationAsync(books, null);
        return Content(result);
    }
}
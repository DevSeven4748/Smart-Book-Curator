using BookCurator.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace BookCurator.MVC.Models.ViewModels;

public class BookEditViewModel
{
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Book title is required.")]
    [StringLength(100, ErrorMessage = "Book title cannot exceed 100 characters.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Author name is required.")]
    [StringLength(100, ErrorMessage = "Author name cannot exceed 100 characters.")]
    public string Author { get; set; } = string.Empty;

    [Required]
    public string Genre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Reading status is required.")]
    public BookStatus Status { get; set; } = BookStatus.ToRead;

    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int? Rating { get; set; }
}
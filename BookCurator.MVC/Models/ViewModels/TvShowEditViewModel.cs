using BookCurator.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace BookCurator.MVC.Models.ViewModels;

public class TvShowEditViewModel
{
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Show title is required.")]
    [StringLength(100, ErrorMessage = "Show title cannot exceed 100 characters.")]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Genre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Watch status is required.")]
    public WatchStatus Status { get; set; } = WatchStatus.ToWatch;

    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int? Rating { get; set; }
}
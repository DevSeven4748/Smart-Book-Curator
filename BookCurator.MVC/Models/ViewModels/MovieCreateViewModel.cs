using BookCurator.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace BookCurator.MVC.Models.ViewModels
{
    public class MovieCreateViewModel
    {
        [Required(ErrorMessage = "Movie title is required.")]
        [StringLength(100, ErrorMessage = "Movie title cannot exceed 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Director name is required.")]
        [StringLength(100, ErrorMessage = "Director name cannot exceed 100 characters.")]
        public string Director { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "View status is required.")]
        public WatchStatus Status { get; set; } = WatchStatus.ToWatch;


        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int? Rating { get; set; }
    }
}

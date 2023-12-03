/*
 * This is the game class 
 */
using System.ComponentModel.DataAnnotations;

namespace MVCFinalProject.Models
{
    public class Game
    {
        [Key]
        public int? GameId { get; set; }

        [Required(ErrorMessage = "Please eneter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1950, 2999, ErrorMessage = "Year must be after 1950.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a developer.")]
        public string? Developer { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string? Genre { get; set; }

        public string Slug =>
          Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}

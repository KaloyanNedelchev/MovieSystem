using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Application.DTOs.MovieDTOs
{
    public class MovieTemplateDTO
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int DirectorID { get; set; }
    }
}

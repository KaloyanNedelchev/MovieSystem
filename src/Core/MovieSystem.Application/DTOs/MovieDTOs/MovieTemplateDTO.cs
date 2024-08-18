using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.DTOs.MovieDTOs
{
    public abstract class MovieTemplateDTO
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

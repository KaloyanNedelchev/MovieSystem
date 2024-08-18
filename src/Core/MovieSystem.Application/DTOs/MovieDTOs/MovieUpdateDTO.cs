using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Application.DTOs.MovieDTOs
{
    public class MovieUpdateDTO : MovieTemplateDTO
    {
        public int MovieID { get; set; }
    }
}

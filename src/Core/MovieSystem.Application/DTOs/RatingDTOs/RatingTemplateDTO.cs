using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.DTOs.RatingDTOs
{
    public class RatingTemplateDTO
    {
        [Required]
        public int UserID { get; set; }
        [Required]
        public int MovieID { get; set; }
        [Required]
        public double MovieRating { get; set; }
    }
}

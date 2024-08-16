using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entities
{
    public class Rating
    {
        [Key]
        public int RatingID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int MovieID { get; set; }
        [Required]
        public double MovieRating { get; set; }

    }
}

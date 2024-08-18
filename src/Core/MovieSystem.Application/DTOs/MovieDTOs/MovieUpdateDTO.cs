using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.DTOs.MovieDTOs
{
    public class MovieUpdateDTO : MovieTemplateDTO
    {
        public int MovieID { get; set; }
    }
}

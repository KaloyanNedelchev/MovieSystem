using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSystem.Application.DTOs.MovieDTOs;
using FluentValidation;

namespace MovieSystem.Application.Validators.MovieValidation
{
    public class CreateMovieDTOValidator : AbstractValidator<MovieCreateDTO>
    {
        public CreateMovieDTOValidator()
        {
            
        }
    }
}

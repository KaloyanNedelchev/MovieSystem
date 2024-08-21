using Microsoft.Identity.Client;
using MovieSystem.Application.DTOs.RatingDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Validators.RatingValidation
{
    public class CreateRatingDTOValidator : AbstractValidator<RatingCreateDTO>
    {
        public CreateRatingDTOValidator()
        {
            
        }
    }
}

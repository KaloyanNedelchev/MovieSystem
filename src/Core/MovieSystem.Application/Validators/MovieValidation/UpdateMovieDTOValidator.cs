using FluentValidation;
using MovieSystem.Application.DTOs.MovieDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Application.Validators.RegistrationValidator
{
    public class UpdateMovieDTOValidator : BaseMovieDTOValidator<MovieUpdateDTO>
    {
        public UpdateMovieDTOValidator() 
        {
            RuleFor(mo => mo.MovieID)
                .NotNull().WithMessage("Id can`t be null")
                .GreaterThanOrEqualTo(0).WithMessage("Id must be a positive number");
        }
    }
}
